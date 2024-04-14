using System;

namespace LogLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var LogLine = new LogLine();
            string errorMessage = "[WARNING]:  Disk almost full\r\n";

            Console.WriteLine(LogLine.Message(errorMessage));
            Console.WriteLine(LogLine.LogLevel(errorMessage));
            Console.WriteLine(LogLine.Reformat(errorMessage));

        }
    }

    class LogLine
    {

        //Implement the (static) LogLine.Message() method to return a log line's message
        
        public static string Message(string message)
        {
            int startIndex = message.IndexOf(":") + 1; // returns the Index of the ":" after the loglevel, incremented by 1
            message = message.Substring(startIndex).Trim(); //Substring without the loglevel and removes blank spaces after and before message

            return message;
        }
        //Implement the (static) LogLine.LogLevel() method to
        //return a log line's log level,
        //which should be returned in lowercase:

        public static string LogLevel(string message)
        {
            message = message.Substring(1, message.IndexOf(":") - 2).ToLower().Trim();         
            return message;
        }

        //Implement the (static) LogLine.
        //Reformat() method that reformats the log line,
        //putting the message first and the log level after it in parentheses:

        public static string Reformat(string message)
        {
            string reformatedMessage = Message(message) + " (" + LogLevel(message) + ")";
            return reformatedMessage;
        }

    }
}

