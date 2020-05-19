using AppKit;
using Foundation;
using System;
using System.Threading;
using Innovative.SolarCalculator;
using Innovative.Geometry;


namespace HueDaytimeColorTemp
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        // Hold reference for timer so that it is garbage collected.
        Timer timer;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            // Run the timer
            var autoEvent = new AutoResetEvent(false);
            var hue = new Hue();

            timer = new Timer(hue.TimerCallback, autoEvent, new TimeSpan(0, 0, 5), new TimeSpan(0, 1, 0));
            //autoEvent.WaitOne();

            //39.801121
            //-105.081451
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }

    class Hue
    {
        public void TimerCallback(object stateInfo)
        {
            //Check Lights and set Color Temp

        }
    }

    class CircadianRhythm
    {
        public Angle Lat
        {
            get;
            set;
        }

        public Angle Long
        {
            get;
            set;
        }

        private SolarTimes times;
        public SolarTimes SolarCalculator
        {
            get
            {
                if (times is null)
                {
                    times = new SolarTimes(DateTime.Now, Lat, Long);
                }

                return times;
            }
        }


        public DateTime GetNextEventTime()
        {
            // Return the next event - 

            var nextEvent = new DateTime();

            return nextEvent;
        }
    }
}
