using BID.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    class Aufgabe2 : Cell
    {
        public object Method1()
        {
            var x = new Cell();
            return x;
        }

        public int Method2()
        {
            Cell i = new Cell();
            int x = i.Grow();
            return 2 * x;

        }

        public bool Method3(int o1)
        {
            Cell D = new Cell();
            bool h = D.IsAlive();
            return h;
        }
    }
}
