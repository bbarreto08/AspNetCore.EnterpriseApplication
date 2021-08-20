using System;

namespace NSE.Core.Messages
{
    public class Message
    {
        public string MessageType { get; set; }
        public Guid AggregateId { get; set; }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
