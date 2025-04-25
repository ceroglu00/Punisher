using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punisher
{
    internal class Logger
    {
        public RichTextBox _box;
        public Logger()
        {

        }
        public Logger(RichTextBox box)
        {
            _box = box;
        }
        public void Log(string mesaj)
        {

            var saat = DateTime.Now.ToString("hh:mm:ss:fff");
            _box.AppendText($"[{saat}] {mesaj}\n");
        }
    }
}
