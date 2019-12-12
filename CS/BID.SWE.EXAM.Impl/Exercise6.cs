using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            string name = "Stefan Strauss";
            int stunde = 17;
            int minute = 00;
            int tag = 12;
            int monat = 12;
            int jahr = 2019;


            string Querry = "insert into TestAbgaben (ID, Tag, Monat, Jahr, Stunde, Minute, Name) VALUES (NEWID(), @tag, @monat, @jahr, @stunde, @minute, @name)";
         
            SqlCommand command = new SqlCommand(Querry);
            command.Parameters.AddWithValue("@Stunde", stunde);
            command.Parameters.AddWithValue("@Minute", minute);
            command.Parameters.AddWithValue("@tag", tag);
            command.Parameters.AddWithValue("@monat", monat);
            command.Parameters.AddWithValue("@jahr", jahr);
            command.Parameters.AddWithValue("@name", name);

            return command;
        }
    }

}