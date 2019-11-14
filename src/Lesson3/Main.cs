using System;
using System.Collections.Generic;

namespace Tours.Delegate.Lesson3
{
    class Main
    {
        delegate bool Predicate(int i);
        public void Run()
        {
            Predicate p;
            int[] a = {1,2,3,4,5};
            p = IsEven;
            int[] evens = Select(a, p);
            Show(evens);
            p = IsOdd;
            int[] odds = Select(a, p);
            Show(odds);
        }
        int[] Select(int[] a, Predicate p) 
        {
            List<int> list = new List<int>();
            foreach (int v in a) {
                if (p(v)) { list.Add(v); }
            }
            return list.ToArray();
        }
        bool IsEven(int i) => (0 == (i % 2));
        bool IsOdd(int i) => (1 == (i % 2));
        void Show(int[] a) { foreach (int i in a) { Console.WriteLine($"{i}"); } }
    }
}

