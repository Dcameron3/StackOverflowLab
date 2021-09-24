using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace StackOverflowLab.Models
{
    public class DAL
    {
        public static MySqlConnection DB;

        public static List<Questions> GetAllQuestions()
        {
            return DB.GetAll<Questions>().ToList();
        }

        public static List<Answers> GetAllAnswers()
        {
            return DB.GetAll<Answers>().ToList();
        }
        public static Questions GetQuestion(int id)
        {
            return DB.Get<Questions>(id);
        }
        public static Answers GetAnswers(int id)
        {
            return DB.Get<Answers>(id);
        }
        public static void AddAnAnswer(Answers answer)
        {
            DB.Insert(answer);
        }
        public static void AddAQuestion(Questions question)
        {
            DB.Insert(question);
        }
        public static void EditAnswer(Answers answer)
        {
            Answers editans = DAL.GetAnswers(answer.ID);
            if (editans != null)
            {
                DB.Update(answer);
            }
        }
    }
}
