using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FBPLib.Util
{
    class ConsoleLogReceiver : LogReceiver
    {
        public void Debug(string s)
        {
            Console.Out.WriteLine(s);
        }

        public void Error(string s)
        {
            Console.Error.WriteLine(s);
        }

        public void Info(string s)
        {
            Console.Out.WriteLine(s);
        }

        public void Warn(string s)
        {
            Console.Out.WriteLine(s);
        }
    }
}
