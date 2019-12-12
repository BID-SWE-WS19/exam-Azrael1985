using BID.SWE.EXAM.Impl;
using NUnit.Framework;
using System;

namespace NUnitExam
{
    public class Tests
    {
        private DateTime date;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var x = new Aufgabe1(true, date, "rot", 1, 2);
            Assert.AreEqual("Cell is on Position X:1 Y:2", x.PrintPostion(1,2));
        }
        [Test]
        public void Test2()
        {
            var x = new Aufgabe1(true, date, "rot", 1, 2);
            Assert.AreEqual("Cell rot born on 01.01.0001 00:00:00 is alive", x.PrintState(true, date,"rot"));
        }
    }
}