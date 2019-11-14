using System;

namespace Tours.Delegate.Lesson0
{
    class Main
    {
        delegate int GetValue();
        public static void Run()
        {
            GetValue getValue;
            getValue = Get100;
            Console.WriteLine($"{getValue()}");
            getValue = Get0_99;
            Console.WriteLine($"{getValue()}");
        }
        static int Get100() => 100;
        static int Get0_99() => new Random().Next(100);
    }
}

