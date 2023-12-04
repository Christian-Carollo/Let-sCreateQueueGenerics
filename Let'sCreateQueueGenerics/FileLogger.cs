using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_sCreateQueueGenerics
{
    public class FileLogger : ILogger
    {

        string file = "log.txt";

        public void Log(string message)
        {
            string text = string.Empty;

            if (File.Exists(file))
            {
                text = File.ReadAllText(file);

            }

            File.WriteAllText(file, text + "\n" + message );
        }

        public void LogError(object value) 
        { 
            throw new NotImplementedException();
        }
    }
}
