using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FBPLib.Util
{
    public interface LogReceiver
    {
        void Info(String s);
        void Debug(String s);
        void Warn(String s);
        void Error(String s);
    }
}
