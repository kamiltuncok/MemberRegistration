﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerService
    {
        public FileLogger(ILog log) : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }
    }
}
