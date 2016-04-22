using System;

namespace FactorioLoader.Main.Helpers
{
    public class ThreadHelper
    {
//        public WaitWhile WaitWhile(bool waitBool)
//        {
//            return new WaitWhile(waitBool);
//        }
    }

    public class WaitWhile
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

        public WaitWhile Variable(bool var)
        {
            waitBool = var;

            return this;
        }

        private bool TimeToGo()
        {
            return DateTime.Now - startTime > timeToWait;
        }

        public WaitWhile OrError(TimeSpan time)
        {
            error = true;
            timeToWait = time;
            return this;
        }

        public WaitWhile Or(TimeSpan time)
        {
            timeToWait = time;
            return this;
        }
    }
}