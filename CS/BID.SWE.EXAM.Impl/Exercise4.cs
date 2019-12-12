using System;
using System.IO;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            UnicodeEncoding uniEncoding = new UnicodeEncoding();
            byte[] mystring = uniEncoding.GetBytes(" Frohe Weihnachten ");
            byte[] myint = uniEncoding.GetBytes("42");
            byte[] mybool = uniEncoding.GetBytes("false");

            MemoryStream mystream = new MemoryStream();
            mystream.Write(mystring, 0, mystring.Length);
            mystream.Write(myint, mystring.Length, mystring.Length + 32);
            mystream.Write(mybool, mystring.Length + 32, mybool.Length);

            return mystream;
        }

        public object Method2(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

