using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using FactorioLoader.Main.Exceptions;
using FactorioLoader.Main.Models.Mods;
using Newtonsoft.Json;

namespace FactorioLoader.Main.Services
{
    public class ModFileService
    {
        protected List<Mod> ScanDirForMods(string directory,bool reserve = false)
        {
            var mods = ScanDirForModsFoldersAndFiles(directory,reserve);

            return mods;
        }

        /// <summary>
        /// Scan a directory for mods and return a list.
        /// TODO enumerate files too
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="reserve"></param>
        /// <returns></returns>
        private List<Mod> ScanDirForModsFoldersAndFiles(string directory,bool reserve)
        {
            var mods = new List<Mod>();
            if (!Directory.Exists(directory))
            {
                throw new PathMissingException();
            }
            var dirEnum = Directory.EnumerateDirectories(directory).GetEnumerator();
            while (dirEnum.MoveNext())
            {
                var curDir = dirEnum.Current;

                var infoJson = GetInfoJsonFromDir(curDir);
                if(infoJson==null)continue;

                mods.Add(new Mod(infoJson,curDir) {InReserve = reserve});
            }

            return mods;
        }

        /// <summary>
        /// Find the info.json in given directory and parse as Json
        /// </summary>
        /// <param name="curDir"></param>
        /// <returns></returns>
        private Dictionary<string,dynamic> GetInfoJsonFromDir(string curDir)
        {
            var infoPath = $"{curDir}\\info.json";

            if (File.Exists(infoPath))
            {
                var infoJsonRaw = File.ReadAllText(infoPath);
                return JsonConvert.DeserializeObject<Dictionary<string,dynamic>>(infoJsonRaw);
            }
            return null;
        }
    }
}