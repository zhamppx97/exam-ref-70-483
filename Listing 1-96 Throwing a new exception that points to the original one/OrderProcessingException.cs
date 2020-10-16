using System;
using System.Runtime.Serialization;

namespace Listing_1_96_Throwing_a_new_exception_that_points_to_the_original_one
{
    [Serializable]
    internal class OrderProcessingException : Exception
    {
        public OrderProcessingException()
        {
        }

        public OrderProcessingException(string message) : base(message)
        {
        }

        public OrderProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}