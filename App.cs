using System;
using System.Windows;

namespace FactorioLoader
{
    public class App
    {
        public static Main.FactorioLoader FactorioLoader;
        
        [STAThread]
        public static void Main(string[] args)
        {
            FactorioLoader = new Main.FactorioLoader();
            FactorioLoader.Run();
        }
    }
}