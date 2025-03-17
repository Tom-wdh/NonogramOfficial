using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace NonogramPuzzle.Initializers
{
    public static class TimerInitializer
    {
        public static void InitializeTimer(ref Timer timer, ref DateTime startTime, EventHandler timerTickHandler)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timerTickHandler;
            startTime = DateTime.Now;
            timer.Start();
        }
    }
}
