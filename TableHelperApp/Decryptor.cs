using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableHelperApp
{
    public class Decryptor
    {
        const int maxColumns = 2;
        public List<int> ErrorLines { get; private set; }

        private enum SplitType
        {
            TAB = '\t',
            ENTER = '\n',
            UNKNOWN
        }

        private enum DataType
        {
            NAME = 0,
            VALUE = 1
        }

        public Decryptor()
        {
            ErrorLines = new List<int>();
        }

        public List<Product> DectyptText(string data) {
            ErrorLines.Clear();
            if ( string.IsNullOrEmpty(data))
            {
                return null;
            }

            var products = new List<Product>();
            switch (GetSplitType(data))
            {
                case SplitType.TAB:
                    TabSplit(data, products);
                    break;
                case SplitType.ENTER:
                    //TODO
                    return null;
                    break;
                case SplitType.UNKNOWN:
                    return null;
                default:
                    return null;
            }

            return products;
        }

        private SplitType GetSplitType(string data)
        {
            if( data.Contains((char)SplitType.TAB))
            {
                return SplitType.TAB;
            }
            else if( data.Contains((char)SplitType.ENTER))
            {
                return SplitType.ENTER;
            }
            return SplitType.UNKNOWN;
        }

        private void TabSplit(string data, List<Product> collection)
        {
            int rowCounter = -1;
            var RowSplitCollection = data.Split((char)SplitType.ENTER);
            foreach (var row in RowSplitCollection)
            {
                rowCounter++;
                var ColumnSplitCollection = row.Split((char)SplitType.TAB);
                if( ColumnSplitCollection.Length != maxColumns)
                {
                    //Save Error line 
                    ErrorLines.Add(rowCounter);
                    Console.WriteLine($"\t(!) Decryption Error! Line={rowCounter} Mode=TAB");
                    continue;
                }
                var product = new Product() { AttributeName = ColumnSplitCollection[(int)DataType.NAME], AttributeValue = ColumnSplitCollection[(int)DataType.VALUE] };
                collection.Add(product);
            }
        }
    }
}
