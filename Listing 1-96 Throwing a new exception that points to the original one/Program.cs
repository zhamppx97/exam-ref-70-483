using System;

namespace Listing_1_96_Throwing_a_new_exception_that_points_to_the_original_one
{
    class Program
    {
        static void Main()
        {
            try
            {
                ProcessOrder();
            }
            catch (MessageQueueException e)
            {
                throw new OrderProcessingException("Error while processing order", e);
            }
        }

        private static void ProcessOrder()
        {
            
        }
    }
}
