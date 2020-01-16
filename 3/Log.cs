using System;
using System.IO;
using System.Text;

namespace Logger
{
    public class Log
    {
        private StringBuilder toFile = new StringBuilder();
        private string timeStamp()
        {
            return DateTime.Now.ToString();
        }

        public string info(string str)
        {
            toFile.AppendLine(timeStamp() + "[INFO] : " + str);
            return null;
        }

        public string emergency(string str)
        {
            toFile.AppendLine(timeStamp() + "[EMERGENCY] : " + str);
            return null;
        }

        public string alert(string str)
        {
            toFile.AppendLine(timeStamp() + "[ALERT] : " + str);
            return null;
        }

        public string critical(string str)
        {
            toFile.AppendLine(timeStamp() + "[CRITICAL] : " + str);
            return null;
        }

        public string error(string str)
        {
            toFile.AppendLine(timeStamp() + "[ERROR] : " + str);
            return null;
        }

        public string warning(string str)
        {
            toFile.AppendLine(timeStamp() + "[WARNING] : " + str);
            return null;
        }

        public string notice(string str)
        {
            toFile.AppendLine(timeStamp() + "[NOTICE] : " + str);
            return null;
        }

        public string debug(string str)
        {
            toFile.AppendLine(timeStamp() + "[DEBUG] : " + str);
            return null;
        }

        public void generate(string path)
        {    
            File.AppendAllText(path +"log.txt", toFile.ToString());
            toFile.Clear();
        }
    }
}