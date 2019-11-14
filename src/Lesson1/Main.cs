using System;

namespace Tours.Delegate.Lesson1
{
    class Main
    {
        delegate int GetValue();
        public void Run()
        {
            GetValue getValue;
            getValue = Get100;
            Console.WriteLine($"{getValue()}");
            getValue = Get0_99;
            Console.WriteLine($"{getValue()}");
        }
        int Get100() => 100;
        int Get0_99() => new Random().Next(100);
    }
}

