using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableHelperApp
{
    public class Product
    {
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }

        public override string ToString()
        {
            return 
                 "<tr>" +
                 $"<td style = \"width: 30%; height: 19px;\" width = \"74%\" height = \"19\">{AttributeName}</td>" +
                 $"<td width = \"74%\" height = \"19\">{AttributeValue}</td>" +
                 "</tr>" + 
                 $"{Environment.NewLine}";
        }
    }

    public class ProductManager
    {
        public static List<Product> Products = new List<Product>();

        public static string GetProductsAsString()
        {
            Console.WriteLine($"(i)\t\t Transforming data to string...");
            string data = "";
            foreach (var item in Products)
            {
                data += item;
            }
            return data;
        }

        public static List<string> GetPruductAttributeNamesAsList()
        {
            var data = new List<string>();
            foreach (var item in Products)
            {
                data.Add(item.AttributeName);
            }
            return data;
        }
    }
}
