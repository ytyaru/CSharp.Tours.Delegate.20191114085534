using System;

namespace Tours.Delegate.Lesson2
{
    class Main
    {
        delegate int GetValue();
        public void Run()
        {
            GetValue getValue;
            getValue  = Get100;
            getValue += Get0_99;
//            getValue += new GetValue(Get100);
//            getValue += new GetValue(Get0_99);
            Console.WriteLine($"{getValue()}");
        }
        int Get100() { Console.WriteLine("called Get100."); return 100; }
        int Get0_99() { Console.WriteLine("called Get0_99."); return new Random().Next(100); }
    }
}

