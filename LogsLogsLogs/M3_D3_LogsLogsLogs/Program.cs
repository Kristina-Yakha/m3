using System;

// TODO: define the 'LogLevel' enum

public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{

    public static LogLevel ParseLogLevel(string logLine)
    {
        string logName = logLine.Substring(1, 3);
        Console.WriteLine(logName);

        switch (logName)
        {
            case "TRC":
                return LogLevel.Trace;
            case "DBG":
                return LogLevel.Debug;
            case "INF":
                return LogLevel.Info;
            case "WRN":
                return LogLevel.Warning;
            case "ERR":
                return LogLevel.Error;
            case "FTL":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
                break;

        }



    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        string logMessage = ":" + message;
        int level = (int)logLevel;

        switch (level)
        {
            case 1:
                return level + logMessage;
                break;
            case 2:
                return level + logMessage;
                break;
            case 4:
                return level + logMessage;
                break;
            case 5:
                return level + logMessage;
                break;
            case 6:
                return level + logMessage;
                break;
            case 42:
                return level + logMessage;
                break;
            default:
                return level + logMessage;
                break;

        }


    }
}
