# The Filenal Countdown

The Filenal Countdown (punny spelling intended) is a countdown (and countup!) timer that works well with OBS and other streaming software. It starts a countdown, based on your settings, and saves it to a text file once per second.

![Animated Example](/screenshots/animation.gif)

## Installation

Download the Setup1.msi installer file from the list of Releases in GitHub.

This only runs on Windows, sorry. If you're using linux or a Mac, you can see this tip I made for accomplishing the same thing using a shell script I wrote: https://youtu.be/vB0jObYSoMI

## Usage

An example of how you might use this with OBS Studio:

1. Try out a 5 second time using The Filenal Countdown by running it, choosing an output filename, and clicking Start
1. Create Scene in OBS and add a Text Source
1. Check the "Read from file" checkbox and Browse to the file that you created in Step 1 above

That's it. You should see "00:00:00" in your OBS window. If you start the countdown again in The Filenal Countdown, you should see the countdown changing in OBS.

I have not tried this with any other software, but I imagine it will be similar with other streaming software. I'm sure people will find other interesting uses for this as well.

## Credits

@rmobis has contributed some good bits, including making it kinder on your CPU and adding a STOP button at the same time!

The clock icon comes from [The Gnome Project](https://www.gnome.org/)
