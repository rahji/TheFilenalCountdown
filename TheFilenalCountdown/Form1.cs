using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFilenalCountdown
{
    public partial class Form1 : Form
    {
        static int totalSeconds;
        static TimeSpan timeSpan;
        static String selectedFormatString;
        static String outputFilename;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int secondsCounted = 0;
        static bool exitFlag = false;
        static bool countUp = false;

        // This is the method to run when the timer is raised, every second
        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            secondsCounted++;

            timeSpan = TimeSpan.FromSeconds(
                (countUp) ? secondsCounted : totalSeconds - secondsCounted);

            Console.WriteLine((countUp) ? "CountUp" : "CountDown");

            System.IO.File.WriteAllText(outputFilename, String.Format(selectedFormatString, timeSpan));
            //Console.WriteLine(selectedFormatString, timeSpan);

            if (secondsCounted == totalSeconds) // Stop the timer.
                exitFlag = true;
        }

        public Form1()
        {
            InitializeComponent();

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
            
            ArrayList timeFormats = new ArrayList();
            timeFormats.Add(new timeFormatSelection("hh:mm:ss", "{0:hh\\:mm\\:ss}"));
            timeFormats.Add(new timeFormatSelection("hh hours, mm minutes, ss seconds", "{0:hh} hours, {0:mm} minutes, {0:ss} seconds"));
            timeFormats.Add(new timeFormatSelection("hh hrs, mm mins, ss secs", "{0:hh} hrs, {0:mm} mins, {0:ss} secs"));
            timeFormats.Add(new timeFormatSelection("mm:ss", "{0:mm\\:ss}"));
            timeFormats.Add(new timeFormatSelection("mm minutes, ss seconds", "{0:mm} minutes, {0:ss} seconds"));
            timeFormats.Add(new timeFormatSelection("mm mins, ss secs", "{0:mm} mins, {0:ss} secs"));
            cbx_format.DataSource = timeFormats;

            // Set the long name as the property to be displayed and the short
            // name as the value to be returned when a row is selected.  Here
            // these are properties; if we were binding to a database table or
            // query these could be column names.
            cbx_format.DisplayMember = "displayString";
            cbx_format.ValueMember = "formatString";

            cbx_format.SelectedIndex = 0;
            cbx_capitalization.SelectedIndex = 0;

            num_hours.Value = Properties.Settings.Default.hrs;
            num_minutes.Value = Properties.Settings.Default.mins;
            num_seconds.Value = Properties.Settings.Default.secs;
            outputFilename = Properties.Settings.Default.filename;
            lbl_filename.Text = outputFilename;
            cbx_format.SelectedIndex = Properties.Settings.Default.formatIndex;
            cbx_capitalization.SelectedIndex = Properties.Settings.Default.capsIndex;
            cbx_replaceCommasWith.Text = Properties.Settings.Default.commasText;
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                outputFilename = saveFileDialog1.FileName;
                lbl_filename.Text = outputFilename;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            countUp = chk_countUp.Checked; 
            selectedFormatString = (String)cbx_format.SelectedValue;

            if (lbl_filename.Text == "None")
            {
                MessageBox.Show("Choose an output file before clicking Start", "No File Selected",
                    MessageBoxButtons.OK);
            }
            else if (num_hours.Value > 0 && !selectedFormatString.Contains("hh"))
            {
                MessageBox.Show("Choose a format that displays hours", "Mismatched Format",
                    MessageBoxButtons.OK);
            }
            else
            {
                // Calculate the total number of seconds - aka iterations of the 1 second timer
                totalSeconds = (int)((num_hours.Value * 3600) + (num_minutes.Value * 60) + num_seconds.Value);

                // this is a little clumsy, but I'm okay with it (trying not to wreck the hh, mm, etc)
                if (cbx_capitalization.SelectedIndex == 1) // ALL CAPS
                    if (selectedFormatString.Contains("hours")) 
                        selectedFormatString = selectedFormatString.Replace(" hours", " HOURS").Replace(" minutes", " MINUTES").Replace(" seconds", " SECONDS");
                    else
                        selectedFormatString = selectedFormatString.Replace(" hrs", " HRS").Replace(" mins", " MINS").Replace(" secs", " SECS");
                else if (cbx_capitalization.SelectedIndex == 2) // Initial Caps
                    selectedFormatString = selectedFormatString.Replace(" h", " H").Replace(" m", " M").Replace(" s", " S");

                if (cbx_replaceCommasWith.Text != "")
                    selectedFormatString = selectedFormatString.Replace(",", cbx_replaceCommasWith.Text);

                btn_start.Enabled = false;
                btn_start.Text = "Counting";

                myTimer.Start();

                while (exitFlag == false)
                {
                    // Processes all the events in the queue.
                    Application.DoEvents();
                }

                // the series of 1 second events is done, given the time that the user specified
                myTimer.Stop();
                exitFlag = false;
                secondsCounted = 0;

                btn_start.Text = "Start";
                btn_start.Enabled = true;
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (myTimer.Enabled == true &&
                MessageBox.Show("Do you want to cancel the counting?", "Quit?",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
            else
            {
                myTimer.Stop();
                myTimer.Dispose();

                Properties.Settings.Default.hrs = num_hours.Value;
                Properties.Settings.Default.mins = num_minutes.Value;
                Properties.Settings.Default.secs = num_seconds.Value;
                Properties.Settings.Default.filename = outputFilename;
                Properties.Settings.Default.formatIndex = cbx_format.SelectedIndex;
                Properties.Settings.Default.capsIndex = cbx_capitalization.SelectedIndex;
                Properties.Settings.Default.commasText = cbx_replaceCommasWith.Text;
                Properties.Settings.Default.Save();
            }
        }

    }


    public class timeFormatSelection
    {
        private string myFormatString;
        private string myDisplayString;

        public timeFormatSelection(string strDisplay, string strFormat)
        {

            this.myFormatString = strFormat;
            this.myDisplayString = strDisplay;
        }

        public string formatString
        {
            get { return myFormatString; }
        }

        public string displayString
        {

            get { return myDisplayString; }
        }

    }
}

