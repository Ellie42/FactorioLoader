using System.Collections.Generic;
using System.Linq;

namespace FactorioLoader.Main.Models.Mods
{
    public partial class Mod
    {
        public Mod()
        {
        }

        /// <summary>
        /// Create object using json from info.json
        /// </summary>
        /// <param name="json"></param>
        /// <param name="folderPath"></param>
        public Mod(Dictionary<string,dynamic> json,string folderPath)
        {
            Name = GetValueFromJson(json,"name") as string;
            Description = GetValueFromJson(json, "description") as string;
            Author = GetValueFromJson(json, "author") as string;
            DependencyString = GetValueFromJson(json, "dependencies") as string;
            Version = GetValueFromJson(json, "version") as string;
            Title = GetValueFromJson(json, "title") as string;

            var splitPath = folderPath.Split('\\');
            FolderName = splitPath[splitPath.Length-1];
        }

        /// <summary>
        /// Return value from json if exists
        /// </summary>
        /// <param name="json"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private dynamic GetValueFromJson(Dictionary<string, dynamic> json, string key)
        {
            if (json.ContainsKey(key))
            {
                return json[key];
            }
            return null;
        }
    }
}