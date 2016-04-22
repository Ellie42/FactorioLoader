using System;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text.RegularExpressions;
using FactorioLoader.Main.Models.Mods;
using MimeSharp;
using SevenZip;

namespace FactorioLoader.Main.Helpers
{
    public class ModFileHelper
    {
        public enum ModFileType
        {
            File,Zip,Folder,GitHubRelease,Unknown,Null
        }

        public static bool IsArchive(string path,out SevenZipExtractor extractor)
        {
            var done = false;
            SevenZipExtractor file = null;
            while (!done)
            {
                try
                {
                    file = new SevenZipExtractor(File.OpenRead(path));
                }
                catch (IOException)
                {
                    continue;
                }
                catch (Exception)
                {
                    extractor = file;
                    return false;
                }
                done = true;
            }
            extractor = file;
            return extractor.Check();
        }

        public static void Extract(SevenZipExtractor extractor, string dest)
        {
            extractor.ExtractArchive(dest);
        }
    }
}