using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Model.Logging;

namespace Emby.Server.Implementations.Logging
{
    public class SimpleLogManager
    {
        public LogSeverity LogSeverity { get; set; }
        public string ExceptionMessagePrefix { get; set; }
        //private volatile FileLogger _fileLogger;

        public ILogger GetLogger(string name)
        {
            return new NamedLogger(name, this);
        }

        public void Log(LogSeverity severity, ReadOnlyMemory<byte> prefix, ReadOnlyMemory<char> message)
        {
                Console.WriteLine(severity + Encoding.UTF8.GetString(prefix.ToArray()) + message.ToString());
        }
    }

    public class NamedLogger : ILogger
    {
        public string Name { get; private set; }

        private ReadOnlyMemory<byte> _nameConcatValue;

        private readonly SimpleLogManager _logManager;

        public NamedLogger(string name, SimpleLogManager logManager)
        {
            Name = name;
            _logManager = logManager;

            var encoding = Encoding.UTF8;

            var nameVal = " " + Name + ": ";
#if NETCOREAPP
            var nameConcatMemory = nameVal.AsMemory();
            var spanBuffer = new byte[encoding.GetMaxByteCount(nameConcatMemory.Length)];
            var span = new Span<byte>(spanBuffer);

            var length = encoding.GetBytes(nameConcatMemory.Span, span);

            _nameConcatValue = new ReadOnlyMemory<byte>(spanBuffer, 0, length);
#else
            _nameConcatValue = new ReadOnlyMemory<byte>(encoding.GetBytes(nameVal));
#endif

        }

        public void Info(string message, params object[] paramList)
        {
            Log(LogSeverity.Info, message, paramList);
        }

        public void Error(string message, params object[] paramList)
        {
            Log(LogSeverity.Error, message, paramList);
        }

        public void Warn(string message, params object[] paramList)
        {
            Log(LogSeverity.Warn, message, paramList);
        }

        public void Debug(string message, params object[] paramList)
        {
            if (_logManager.LogSeverity == LogSeverity.Info)
            {
                return;
            }
            Log(LogSeverity.Debug, message, paramList);
        }

        public void Fatal(string message, params object[] paramList)
        {
            Log(LogSeverity.Fatal, message, paramList);
        }

        public void FatalException(string message, Exception exception, params object[] paramList)
        {
            ErrorException(message, exception, paramList);
        }

        public void ErrorException(string message, Exception exception, params object[] paramList)
        {
            LogException(LogSeverity.Error, message, exception, paramList);
        }

        private void LogException(LogSeverity level, string message, Exception exception, params object[] paramList)
        {
            message = FormatMessage(message, paramList).Replace(Environment.NewLine, ". ");

            var messageText = LogHelper.GetLogMessage(exception);

            var prefix = _logManager.ExceptionMessagePrefix;

            if (!string.IsNullOrWhiteSpace(prefix))
            {
                messageText.Insert(0, prefix);
            }

            LogMultiline(message, level, messageText);
        }

        private static string FormatMessage(string message, params object[] paramList)
        {
            if (paramList != null)
            {
                for (var i = 0; i < paramList.Length; i++)
                {
                    var obj = paramList[i];

                    message = message.Replace("{" + i + "}", (obj == null ? "null" : obj.ToString()));
                }
            }

            return message;
        }

        public void LogMultiline(string message, LogSeverity severity, StringBuilder additionalContent)
        {
            if (severity == LogSeverity.Debug && _logManager.LogSeverity == LogSeverity.Info)
            {
                return;
            }

            additionalContent.Insert(0, message + Environment.NewLine);

            const char tabChar = '\t';

            var text = additionalContent.ToString()
                .Replace(Environment.NewLine, Environment.NewLine + tabChar)
                .TrimEnd(tabChar);

            if (text.EndsWith(Environment.NewLine))
            {
                text = text.Substring(0, text.LastIndexOf(Environment.NewLine, StringComparison.OrdinalIgnoreCase));
            }

            Log(severity, text);
        }

        public void Log(LogSeverity severity, string message, params object[] paramList)
        {
            _logManager.Log(severity, _nameConcatValue, FormatMessage(message, paramList).AsMemory());
        }

        public void Log(LogSeverity severity, ReadOnlyMemory<char> message)
        {
            _logManager.Log(severity, _nameConcatValue, message);
        }

        public void Info(ReadOnlyMemory<char> message)
        {
            _logManager.Log(LogSeverity.Info, _nameConcatValue, message);
        }

        public void Debug(ReadOnlyMemory<char> message)
        {
            _logManager.Log(LogSeverity.Debug, _nameConcatValue, message);
        }

        public void Error(ReadOnlyMemory<char> message)
        {
            _logManager.Log(LogSeverity.Error, _nameConcatValue, message);
        }

        public void Warn(ReadOnlyMemory<char> message)
        {
            _logManager.Log(LogSeverity.Warn, _nameConcatValue, message);
        }
    }
}
