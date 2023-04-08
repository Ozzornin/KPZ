using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    public class ConsoleToFileAdapter : Logger
    {

        private FileWriter _writer;        

        public ConsoleToFileAdapter(FileWriter writer)
        {
            _writer = writer;
        }

        public override void Error(string message)
        {
            _writer.WriteLine(message);
        }
        public override void Log(string message)
        {
            _writer.WriteLine(message);
        }
        public override void Warn(string message)
        {
            _writer.WriteLine(message);
        }
    }
}
