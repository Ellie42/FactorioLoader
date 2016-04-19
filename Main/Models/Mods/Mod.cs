using System;
using System.IO;

namespace FactorioLoader.Main.Models.Mods
{
    public partial class Mod : IEquatable<Mod>
    {
        public string Name;
        public string Title;
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

        protected string GetMainPath()
        {
            return App.FactorioLoader.Config.ModFolder + "\\" + FolderName;
        }

        protected string GetReservePath()
        {
            return App.FactorioLoader.Config.ReserveFolder + "\\" +
                FolderName;
        }

        public void MoveToReserve()
        {
            if (InReserve) return;

            if (Directory.Exists(GetReservePath()))
            {
                Directory.Delete(GetMainPath());
            }
            var moved = false;

            while (!moved)
            {
                try
                {
                    Directory.Move(GetMainPath(),GetReservePath());
                }
                catch (IOException)
                {
                    continue;
                }
                moved = true;
            }
            InReserve = true;
        }

        public void MoveToMain()
        {
            if (!InReserve) return;

            if (Directory.Exists(GetMainPath()))
            {
                Directory.Delete(GetReservePath());
            }
            var moved = false;

            while (!moved)
            {
                try
                {
                    Directory.Move(GetReservePath(), GetMainPath());
                }
                catch (IOException)
                {
                    continue;
                }
                moved = true;
            }
            InReserve = false;
        }
    }
}