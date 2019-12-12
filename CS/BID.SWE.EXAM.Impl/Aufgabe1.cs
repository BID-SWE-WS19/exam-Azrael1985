using BID.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
   
    public class Aufgabe1 : ICellPrinter
    {
        private string rs = String.Empty;
        private string pos = String.Empty;
        public Aufgabe1()
        {

        }
        public Aufgabe1(bool a, DateTime d, string c, int x, int y)
        {
            this.rs = PrintState(a, d, c);
            this.pos = PrintPostion(x, y);
        }


        public string PrintPostion(int x, int y)
        {
            string rs = $"Cell is on Position X:{x} Y:{y}";
            return rs;
        }

        public string PrintState(bool alive, DateTime date, string color)
        {
            if (alive)
            {
                return $"Cell {color} born on {date} is alive";
            }
            else
            {
                return $"Cell {color} born on {date} is dead";
            }
        }
    }
}
