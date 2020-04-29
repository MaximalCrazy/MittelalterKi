using Microsoft.Extensions.Logging;
using System;

namespace MittelalterKi.Data.StateMachine
{
    public class WebLogger<T> : ILogger<T>
    {
        private readonly Action<WebLoggerEintrag> logAction;

        public WebLogger(Action<WebLoggerEintrag> logAction)
            {
            this.logAction = logAction;
        }

        public LogLevel MinLogLevel { get; set; } = LogLevel.Debug;

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotSupportedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= MinLogLevel;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel)) return;

            if (formatter != null)
            {
                logAction(new WebLoggerEintrag(logLevel.ToString(), $"{eventId}: {formatter(state, exception)}"));
            }
            else
            {
                logAction(new WebLoggerEintrag(logLevel.ToString(), $"{eventId}: {state}"));
            }
        }
    }

    public class WebLoggerEintrag
    {
        private static ulong sNr = 0;
        public readonly ulong Nr;
        public readonly string LogLevel;
        public readonly string Msg;

        public WebLoggerEintrag(string logLevel, string msg)
        {
            Nr = sNr++;
            LogLevel = logLevel;
            Msg = msg;
        }
    }
}
