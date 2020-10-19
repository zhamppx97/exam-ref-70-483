using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Listing_1_98_Creating_a_custom_exception
{
    [Serializable]
    public class OrderProcessingException : Exception, ISerializable
    {
        public int OrderId { get; private set; }
        public OrderProcessingException(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "https://www.example.com/infoaboutexception";
        }

        public OrderProcessingException(int orderId, string message, Exception innerException) : base(message, innerException)
        {
            OrderId = orderId;
            this.HelpLink = "https://www.example.com/infoaboutexception";
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("OrderId", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("OrderId", OrderId, typeof(int));
        }
    }
}
