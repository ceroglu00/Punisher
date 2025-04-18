using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punisher
{
    internal class Logger
    {
        public void Log(string mesaj, RichTextBox box)
        {
            box.AppendText(mesaj + "\n");
        }
    }
}
