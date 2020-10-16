using System;
using System.Runtime.Serialization;

namespace Listing_1_96_Throwing_a_new_exception_that_points_to_the_original_one
{
    [Serializable]
    internal class MessageQueueException : Exception
    {
        public MessageQueueException()
        {
        }

        public MessageQueueException(string message) : base(message)
        {
        }

        public MessageQueueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MessageQueueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}