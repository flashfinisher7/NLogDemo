using System;
using NLog;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace NlogSession
{
   class Nlog
   {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message)
       {
           logger.Debug(message);
       }
       public void LogError(string message)
       {
           logger.Error(message);
       }
       public void LogInfo(String message)
       {
           logger.Info(message);
       }
       public void LogWarn(String message)
       {
           logger.Warn(message);
       }
   }
}