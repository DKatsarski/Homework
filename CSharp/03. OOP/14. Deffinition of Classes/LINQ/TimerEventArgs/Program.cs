namespace ExtensionMethodsDelegatesLambdaLINQ.Timer
{
    using System;
    /// <summary>
    /// Event Args
    /// </summary>
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs()
        {
            this.Time = DateTime.Now;
        }

        public DateTime Time { get; private set; }
    }
}
Status API Training Shop Blog About
© 2016 GitHub, Inc.Terms Privacy Security Contact 