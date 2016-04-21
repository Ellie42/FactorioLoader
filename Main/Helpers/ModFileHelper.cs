using System;
using System.Text.RegularExpressions;

namespace FactorioLoader.Main.Helpers
{
    public class ModFileHelper
    {
        public enum ModFileType
        {
            File,Zip,Folder,GitHubRelease,Unknown,Null
        }

        public static ModFileType GetTypeFromUrl(string url)
        {
            if (url == null) return ModFileType.Null;

            if(IsZip(url)) return ModFileType.Zip;

            return ModFileType.Unknown;
        }

        private static bool IsZip(string url)
        {
            var matches =
                Regex.Match(url, @"(?:([^:\/?#]+):)?(?:\/\/([^\/?#]*))?([^?#]*\.(?:zip))(?:\?([^#]*))?(?:#(.*))?");
            if (matches.Groups.Count > 1)
            {
                return true;
            }

            if (Regex.IsMatch(url, @"(forums.factorio.com\/download\/file.php)"))
            {
                return true;
            }

            return false;
        }
    }
}