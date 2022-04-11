using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace DBApp
{
    public static class Logger
    {


         public static List<string> _logs = new List<string>();

         public static void log(int level,string message)
         {
             switch (level)
             {
                 case 0:
                        _logs.Add($"[MESSAGE][{DateTime.Now}]:{message}");
                     break;
                 case 1:
                     _logs.Add($"[WARN][{DateTime.Now}]:{message}");
                     break;
                 case 2:
                     _logs.Add($"[ERROR][{DateTime.Now}]:{message}");
                     break;
                 case 3:
                     _logs.Add($"[FATAL][{DateTime.Now}]:{message}");
                     break;
             }
         }

         public static void HandleException(object sender, UnhandledExceptionEventArgs a)
         {
             _logs.Add($"Program crash at {DateTime.Now} with error {sender}");
             File.WriteAllLines($"{DateTime.Now}.log",_logs);
         }
    }
}