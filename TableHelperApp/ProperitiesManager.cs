using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableHelperApp
{
    public class ProperitiesManager
    {
        public static string RelativeDataPath = @".\data";
        public static string AbsoluteDataPath = $@"{Directory.GetCurrentDirectory()}\data";

        public static string HTMLFileName = "temp.html";
        public static string RelativeHTMLFilePath = $@"{RelativeDataPath}\{HTMLFileName}";
        public static string AbsoluteHTMLFilePath = $@"{AbsoluteDataPath}\{HTMLFileName}";

        public static string StringCollectionFileName = "collection.txt";
        public static string RelativeStringCollectionFileName = $@"{RelativeDataPath}\{StringCollectionFileName}";
        public static string AbsoluteStringCollectionFileName = $@"{AbsoluteDataPath}\{StringCollectionFileName}";

        public static void Init()
        {
            if( !Directory.Exists(RelativeDataPath))
            {
                Directory.CreateDirectory(RelativeDataPath);
                Console.WriteLine($"(i)\t Directory \"{RelativeDataPath}\" created!");
            }
            Collector.Init(RelativeStringCollectionFileName);
        }
    }
}
