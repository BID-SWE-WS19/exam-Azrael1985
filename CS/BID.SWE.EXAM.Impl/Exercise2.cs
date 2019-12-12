using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            var x = new Aufgabe2();
            return x;
        }

        public int Method2()
        {
            var x = new Aufgabe2();
            return x.Grow();

        }

        public bool Method3(int o1)
        {
            var x =new Aufgabe2();
            var y=x.Method3(o1);
            return y;
        }
    }
}