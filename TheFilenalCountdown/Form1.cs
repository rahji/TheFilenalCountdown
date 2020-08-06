using System;
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
        static String timeFormat;
        static String outputFilename;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int secondsCounted = 0;
        static bool exitFlag = false;

        // This is the method to run when the timer is raised, every second
        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            secondsCounted++;

            timeSpan = TimeSpan.FromSeconds(totalSeconds - secondsCounted);

            // System.IO.File.WriteAllText(outputFilename, outputString);
            Console.WriteLine("Time of Travel: {0:dd\\.hh\\:mm\\:ss} days", timeSpan);
            xxx change the combobox to use key/value pairs and put this kind of format in each selection

            if (secondsCounted == totalSeconds) // Stop the timer.
                exitFlag = true;
        }

        public Form1()
        {
            InitializeComponent();
            cbx_format.SelectedIndex = 3;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
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
            if (false && lbl_filename.Text == "None")
            {
                MessageBox.Show("Choose an output file before clicking Start", "No File Selected",
                    MessageBoxButtons.OK);
            }
            else if (false && num_hours.Value > 0 && ! cbx_format.Text.Contains("hh"))
            {
                MessageBox.Show("You need to choose a format that displays hours", "Incorrect Format",
                    MessageBoxButtons.OK);
            }
            else
            {
                // Calculate the total number of seconds - aka iterations of the 1 second timer
                totalSeconds = (int)((num_hours.Value * 3600) + (num_minutes.Value * 60) + num_seconds.Value);
                timeFormat = cbx_format.Text.Replace("hh:", "hh\\:").Replace("mm:", "mm\\:");

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
                MessageBox.Show("Do you want to abandon the countdown?", "Quit?",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
            else
            {
                myTimer.Stop();
                myTimer.Dispose();
            }
        }

    }
}

