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

        public enum SplitType
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

        public List<Product> DectyptText(string data, SplitType splitType) {
            ErrorLines.Clear();
            if ( string.IsNullOrEmpty(data))
            {
                return null;
            }

            var products = new List<Product>();
            switch (splitType)
            {
                case SplitType.TAB:
                    TabSplit(data, products);
                    break;
                case SplitType.ENTER:
                    LineSplit(data, products);
                    break;
                case SplitType.UNKNOWN:
                    return null;
                default:
                    return null;
            }
            //Empty products == error
            if( products.Count == 0)
            {
                return null;
            }
            else return products;
        }

        public SplitType GetSplitType(string data)
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
                //whitespace check
                if ( string.IsNullOrWhiteSpace(row))
                {
                    //Save Error line 
                    ErrorLines.Add(rowCounter);
                    Console.WriteLine($"\t(!) Decryption Error! Line={rowCounter} Mode=TAB");
                    continue;
                }
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

        private void LineSplit(string data, List<Product> collection)
        {

            var RowSplitCollection = data.Split((char)SplitType.ENTER);
            //Pair split
            if( RowSplitCollection.Length % 2 == 0)
            {
                PairSplit(RowSplitCollection, collection);
            }
            else PairSplit(RowSplitCollection, collection, RowSplitCollection.Length-1);
        }

        private void PairSplit(string[] rows, List<Product> collection, int end = -1)
        {
            int rowCounter = -1;
            Product product = null;

            foreach (var row in rows)
            {
                rowCounter++;
                //whitespace check
                if (string.IsNullOrWhiteSpace(row))
                {
                    //Save Error line (line above if possible!)
                    if( rowCounter%2 != 0 )
                        ErrorLines.Add(rowCounter-1);
                    else
                        ErrorLines.Add(rowCounter);
                    Console.WriteLine($"\t(!) Decryption Error! Line={rowCounter} Mode=TAB");
                }
                //For unpaired row
                if ( rowCounter >= end && end != -1)
                {
                    ErrorLines.Add(rowCounter);
                    return;
                }

                if (rowCounter % 2 == 0)
                {
                    product = new Product();
                    product.AttributeName = row;
                }
                else
                {
                    product.AttributeValue = row;
                    collection.Add(product);
                }
            }
        }

    }
}
