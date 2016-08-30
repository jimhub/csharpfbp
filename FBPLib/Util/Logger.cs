using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FBPLib.Util
{
    public class Logger
    {
        private static LogReceiver logReceiver;

        static Logger()
        {
            logReceiver = new ConsoleLogReceiver();
        }

        public static void SetLogReceiver(LogReceiver logReceiver)
        {
            Logger.logReceiver = logReceiver;
        }

        public static void Info(object o)
        {
            Info(o.ToString());
        }

        public static void Info(string s, params object[] args)
        {
            logReceiver.Info(string.Format(s, args));
        }

        public static void Debug(object o)
        {
            Debug(o.ToString());
        }

        public static void Debug(string s, params object[] args)
        {
            logReceiver.Debug(string.Format(s, args));
        }

        public static void Warn(object o)
        {
            Warn(o.ToString());
        }

        public static void Warn(string s, params object[] args)
        {
            logReceiver.Warn(string.Format(s, args));
        }

        public static void Error(object o)
        {
            Error(o.ToString());
        }

        public static void Error(string s, params object[] args)
        {
            logReceiver.Error(string.Format(s, args));
        }

    }
}
