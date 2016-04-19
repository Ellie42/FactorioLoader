using System;

namespace FactorioLoader.Main.Exceptions
{
    public class PathMissingException : Exception
    {
        public PathMissingException()
        {
        }

        public PathMissingException(string message)
            : base(message)
        {
        }

        public PathMissingException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}