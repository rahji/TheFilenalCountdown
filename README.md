# The Filenal Countdown

The Filenal Countdown (punny spelling intended) is a countdown timer that works well with OBS and other streaming software. It starts a countdown, based on your settings, and saves it to a text file once per second. **(By the way, it can also count up now.)**

![Animated Example](/screenshots/animation.gif)

## Installation

Download either the setup.exe or Setup1.msi installer file from the list of Releases in GitHub.

This only runs on Windows, sorry. If you're using linux or a Mac, you can see this tip I made for accomplishing the same thing using a shell script I wrote: https://youtu.be/vB0jObYSoMI

## Usage

An example of how you might use this with OBS Studio:

1. Try out a 5 second time using The Filenal Countdown by running it, choosing an output filename, and clicking Start
1. Create Scene in OBS and add a Text Source
1. Check the "Read from file" checkbox and Browse to the file that you created in Step 1 above

That's it. You should see "00:00:00" in your OBS window. If you start the countdown again in The Filenal Countdown, you should see the countdown changing in OBS.

I have not tried this with any other software, but I imagine it will be similar with other streaming software. I'm sure people will find other interesting uses for this as well.

## Caveats

As of two days ago, I had never attempted to write a Windows program. But I have been programming for about 35 years, and this is a simple program so it worked out just as I'd hope. I think it's working great, but if you find a problem create an issue in GitHub. 

To make things a little easier on myself and keep this program simple, I took a shortcut in the way that the timer works. According to Microsoft, the type of timer that I'm using can be inaccurate by up to 57 milliseconds (57 thousands of a second). I don't expect it will make a difference for you if you're using this as a countdown for streaming software, but if you're trying to have a 48 hour countdown for a marathon or something, I imagine you will see a discrepancy by the end. I am unlikely to go back and make a version 2 of this, since I expect that I will be one of three people who download and use it. If I do go back into it, though, I will include Pause, Stop, and Reset buttons (which were not possible in the way that it's currently written.)

## Credits

The icon comes from [The Gnome Project](https://www.gnome.org/)
