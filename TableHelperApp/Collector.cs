using FileControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableHelperApp
{
    public class Collector
    {
        public static AutoCompleteStringCollection Collection;
        private static string _collectionFilePath; 

        public static void Init(string collectionFilePath)
        {
            Console.WriteLine($"(i)\t Collector Initialiaze...");

            _collectionFilePath = collectionFilePath;
            Collection = LoadFromFile();         
        }

        private static AutoCompleteStringCollection GenerateCollection(string[] data)
        {
            Console.WriteLine($"(i)\t\t Generating collection...");
            var collection = new AutoCompleteStringCollection();

            if (data != null)
            {
                foreach (var item in data)
                {
                    if( !collection.Contains(item) )
                        collection.Add(item);
                }
            }

            return collection;
        }

        public static void UpdateCollection(string[] items, bool saveToFile = true)
        {
            Console.WriteLine($"(i)\t\t Updating collection...");
            foreach (var item in items)
            {
                //Duplicate check
                if(!Collection.Contains(item) && item!=string.Empty)
                    Collection.Add(item);
            }
            if(saveToFile)
            {
                SaveToFile();
            }
        }

        public static void UpdateCollectionAsync(string[] items, bool saveToFile = true)
        {
            Console.WriteLine($"(i)\t\t Updating collection...");
            foreach (var item in items)
            {
                //Duplicate check
                if (!Collection.Contains(item) && item != string.Empty)
                    Collection.Add(item);
            }
            if (saveToFile)
             {
                SaveToFileAsync();
             }
        }

        public static AutoCompleteStringCollection LoadFromFile()
        {
            string data = FileManager.LoadFile(_collectionFilePath);
            var items = data.Split('\n');
            return GenerateCollection(items);
        }

        private static void SaveToFile()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Collection)
            {
                //Null or empty chceck
                if ( !string.IsNullOrEmpty(item.ToString()) )
                    stringBuilder.AppendLine(item.ToString());
            }
            FileManager.SaveFile(_collectionFilePath, stringBuilder.ToString());
        }

        private static async void SaveToFileAsync()
        {
            await Task.Run(() => {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in Collection)
                {
                    //Null or empty chceck
                    if (!string.IsNullOrEmpty(item.ToString()))
                        stringBuilder.AppendLine(item.ToString());
                }
                FileManager.SaveFile(_collectionFilePath, stringBuilder.ToString());
            });
        }

        public static void ClearCollection(bool onlyLocal)
        {
            Collection.Clear();
            if( !onlyLocal)
            {
                File.Delete(_collectionFilePath);
            }
            Console.WriteLine($"(!)\t Collection cleared! OnlyLocal={onlyLocal}");
        }
    }
}
