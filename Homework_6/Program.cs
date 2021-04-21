using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter cnt = new();
            Handler1 handler1 = new();
            Handler2 handler2 = new();

            cnt.Notify += handler1.message;
            cnt.Notify += handler2.message;
            cnt.StartCounter();

            
        }
    }
}
