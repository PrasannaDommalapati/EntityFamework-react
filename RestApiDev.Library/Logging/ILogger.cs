using System;

namespace RestApiDev.Library.Logging
{
    public interface ILogger
    {
        ILoggable Loggable { get; set; }

        void LogException(Exception exception);

        void Log(string message);
    }
}