using System;

namespace Listing_1_84_Custom_event_arguments
{
    class Program
    {
        public class MyArgs : EventArgs
        {
            public int _value { get; set; }
            public MyArgs(int value)
            {
                _value = value;
            }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };
            public void Raise()
            {
                OnChange(this, new MyArgs(97));
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e._value);
            p.Raise();
        }

        static void Main()
        {
            CreateAndRaise();
        }
    }
}
