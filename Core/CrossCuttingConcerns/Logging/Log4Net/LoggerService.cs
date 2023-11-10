using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErrorEnabled => IsFatalEnabled;

        public void Info(object logMessage)
        {
            if (_log.IsInfoEnabled)
            {
                _log.Info(logMessage);
            }
        }
        public void Warn(object logMessage)
        {
            if (_log.IsWarnEnabled)
            {
                _log.Warn(logMessage);
            }
        }
        public void Error(object logMessage)
        {
            if (_log.IsErrorEnabled)
            {
                _log.Error(logMessage);
            }
        }
        public void Fatal(object logMessage)
        {
            if (_log.IsFatalEnabled)
            {
                _log.Fatal(logMessage);
            }
        }

    }
}
