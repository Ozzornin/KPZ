using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    public class FileWriter
    {
        private string _path;

        public FileWriter(string path)
        {
            _path = path;
        }
        public void Write(string text) { 
            using(StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.Write(text);
            }        
        }
        public void WriteLine(string text)
        {
            using(StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.WriteLine(text);                
            }
        }
    }
}
