using System;

namespace FactorioLoader.Main.Exceptions
{
    public class TimeoutException : Exception
    {
        public TimeoutException(string message) : base(message)
        {
        }
    }
}