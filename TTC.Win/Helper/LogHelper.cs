using System;
using System.Collections.Generic;
using System.Text;

namespace TTC.Win.Helper
{
    internal static class LogHelper
    {
        internal static event EventHandler<string> NewLineHandler;
        internal static event EventHandler<string> AppendHandler;
        internal delegate bool Condition();
        private static string _timeFormat = "yyyy-MM-dd hh:mm:ss";

        internal static void LogAppend(string msg)
        {
            if(AppendHandler != null)   
                AppendHandler.Invoke(msg, null);
        }
        internal static void Log(string msg)
        {
            if(NewLineHandler != null)  
               NewLineHandler.Invoke($"[{DateTime.Now.ToString(_timeFormat)}] [info] " + msg, null);   
        }

        internal static void Param(string msg)
        {
            if (NewLineHandler != null)
                NewLineHandler.Invoke($"[{DateTime.Now.ToString(_timeFormat)}] [param] " + msg, null);
        }

        internal static void Error(string msg)
        {
            if (NewLineHandler != null)
                NewLineHandler.Invoke($"[{DateTime.Now.ToString(_timeFormat)}] [error] " + msg, null);
        }

        internal static void Webcast(string msg)
        {
            if (NewLineHandler != null)
                NewLineHandler.Invoke($"[{DateTime.Now.ToString(_timeFormat)}] [webcast] " + msg, null);
        }


        internal static bool Assert(string msg, string tMsg, string fMsg, bool condition)
        {
            bool flag = false;
            if (NewLineHandler != null)
            {
                NewLineHandler.Invoke($"[{DateTime.Now.ToString(_timeFormat)}] [assert] " + msg.PadRight(20, ' '), null);
                if (condition)
                {
                    flag = true;
                    LogAppend(tMsg);
                }
                else
                {
                    LogAppend(fMsg);
                }
            }
            return flag;
        }
    }
}
