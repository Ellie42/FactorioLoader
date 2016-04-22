using System;

namespace FactorioLoader.Main.Exceptions
{
    public class ModFileUnavailableException : Exception
    {
        public ModFileUnavailableException(string message) : base(message)
        {
        }
    }
}