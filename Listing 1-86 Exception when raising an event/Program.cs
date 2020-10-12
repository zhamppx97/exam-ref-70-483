using System;

namespace Listing_1_86_Exception_when_raising_an_event
{
    class Program
    {
        public class Pub
        {
            public event EventHandler OnChange = delegate { };
            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e) => { throw new Exception(); };
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 called");
            p.Raise();
        }

        static void Main()
        {
            CreateAndRaise();
        }
    }
}
