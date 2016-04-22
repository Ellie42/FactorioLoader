using System;

namespace FactorioLoader.Main.Helpers
{
    public class ThreadHelper
    {
//        public WaitFor WaitFor(bool waitBool)
//        {
//            return new WaitFor(waitBool);
//        }
    }

    public class WaitFor
    {
        public bool IsTrue
        {
            get
            {
                if (TimeToGo() && error) throw new Exceptions.TimeoutException("Time Limit Exceeded");
                return TimeToGo() || waitBool;
            }
        }

        public bool IsFalse
        {
            get
            {
                if(TimeToGo() && error) throw new Exceptions.TimeoutException("Time Limit Exceeded");
                return TimeToGo() || !waitBool;
            }
        }

        private bool error = false;
        private bool waitBool;
        private DateTime startTime = DateTime.Now;
        private TimeSpan timeToWait;

        public WaitFor Variable(bool var)
        {
            waitBool = var;

            return this;
        }

        private bool TimeToGo()
        {
            return DateTime.Now - startTime > timeToWait;
        }

        public WaitFor OrError(TimeSpan time)
        {
            error = true;
            timeToWait = time;
            return this;
        }

        public WaitFor Or(TimeSpan time)
        {
            timeToWait = time;
            return this;
        }
    }
}