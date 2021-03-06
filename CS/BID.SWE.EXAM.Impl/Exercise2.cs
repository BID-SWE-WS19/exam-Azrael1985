﻿using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            return new MyCell();
        }

        public int Method2()
        {
            return new MyCell().Grow();
        }

        public bool Method3(int o1)
        {
            return new MyCell().IsAlive(o1);
        }
    }

    public class MyCell : Cell
    {
        public override int Grow()
        {
            return _size * 2;
        }
        public bool IsAlive(int neighbour)
        {
            if (neighbour % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}