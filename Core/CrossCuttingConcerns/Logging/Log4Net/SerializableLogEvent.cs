using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        private LoggingEvent _event;

        public SerializableLogEvent(LoggingEvent @event)
        {
            _event = @event;
        }

        public string UserName => _event.UserName;
        public object MessageObject => _event.MessageObject;
    }
}
