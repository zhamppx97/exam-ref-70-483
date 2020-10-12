using System;

namespace Listing_1_85_Custom_event_accessor
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
            private event EventHandler<MyArgs> onChange = delegate { };

            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            public void Raise()
            {
                onChange(this, new MyArgs(97));
            }
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
