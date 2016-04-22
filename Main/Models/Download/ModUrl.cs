using FactorioLoader.Main.Helpers;

namespace FactorioLoader.Main.Models.Download
{
    public class ModUrl
    {
        public string Url { get; set; }
        public ModFileHelper.ModFileType Type { get; set; }

        public ModUrl(string url)
        {
            Url = url;
        }
    }
}