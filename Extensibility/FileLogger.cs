using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("You need to provide a valid path");
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");                
        }

        public void LogInfo(string messsage)
        {
            Log(messsage, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using(var streamWriter =  new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
