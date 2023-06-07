using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAT.Strategies.Parsers
{
    internal class SquareFileStrategy : IFileStrategy
    {
        public object ParseFile(String path)
        {
            Console.WriteLine(path);
            String sudokuString;
            using(var sr = new StreamReader(path))
            {
                sudokuString = sr.ReadToEnd();
            }
            int counter = 0;

            double dimension = Math.Sqrt(sudokuString.Length);

            int[,] sudokuArray = new int[(int)dimension, (int)dimension];

            for(int i = 0; i < dimension; i++)
            {
                for(int j = 0; j < dimension; j++)
                {
                    sudokuArray[i, j] = (int)Char.GetNumericValue(sudokuString[counter]);
                    counter++;
                }
            }

            return sudokuArray;
        }
    }
}