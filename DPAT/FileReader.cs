using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void loadFile()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();


        }
    }
}
