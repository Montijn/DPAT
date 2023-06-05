using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAT.Strategies.Parsers
{
    internal class SquareFileStrategy : IFileStrategy
    {
        public object ParseFile(object data)
        {
            String sudokuString = data as String;

            double dimension = Math.Sqrt(sudokuString.Length);

            int[,] sudokuArray = new int[(int)dimension, (int)dimension];

            for(int i = 0; i < dimension; i++)
            {
                for(int j = 0; j < dimension; j++)
                {

                }
            }
        }
    }
}
