using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace PracticeProject
{
    enum weekDays
    {
        Monday = 0,
        Teusday = 12,
        Webdnesday = 14,
        Thursday = 54,
        Friday = 87,
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Path.Combine("C","MyDocuments"));


            
            try
            {
                int a = 0, b = 10, d;
                d = b / a;

            }
            catch (Exception ex)
            {
                ILogger logs = Logs.getLogFile(); 
                logs.Error(ex.Message, "Message");// Log the exception with a message
            }
            finally
            {
                Log.CloseAndFlush(); // Flush and close the log file
            }
            // Console.ReadKey();
        }
    }
}
