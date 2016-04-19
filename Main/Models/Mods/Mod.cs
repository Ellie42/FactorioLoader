using System;

namespace FactorioLoader.Main.Models.Mods
{
    public partial class Mod : IEquatable<Mod>
    {
        public string Name;
        public string Description;
        public string Version;
        public string Author;
        public string Url;
        public string DependencyString;
        public string FolderName;
        public bool InReserve = false;
        public bool HaveFiles = false;
        public bool HaveData = true;

        public bool Equals(Mod other)
        {
            return other.Name == Name && other.Version == Version;
        }
    }
}