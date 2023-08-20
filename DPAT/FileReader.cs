using DPAT.Strategies.Parsers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DPAT
{
    public sealed class FileReader
    {
        private FileReader() { }

        private static FileReader _instance;

        public static FileReader GetInstance()
        {
            if(_instance == null)
            {
                _instance = new FileReader();
            }
            return _instance;
        }

        public int[,] loadFile()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            IFileStrategy strategy;
            Console.WriteLine(fd.FileName);
            string extension = Path.GetExtension(fd.FileName);
            Console.WriteLine(extension);
            switch (extension)
            {
                case ".samurai":
                    break;
                case ".jigsaw":
                    break;
                default:
                    strategy = new SquareFileStrategy();
                    return (int[,])strategy.ParseFile(fd.FileName); // Return the parsed array
            }
            return null; // Return appropriate value for cases with no array
        }
    }
}
