using System;
using System.IO;
using Serilog;

namespace PracticeProject
{
    class Logs
    {
       public static ILogger getLogFile()
        {
            string logFilePath = Path.Combine(@"E:\", "Errors","Errors.txt");
            Console.WriteLine(logFilePath);
           return Log.Logger = new LoggerConfiguration()
          .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day) // Log to a file
          .CreateLogger();
        }
    }
}
