using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace StackOverflowLab.Models
{
    [Table("Answers")]
    public class Answers
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public string QuestionID { get; set; }
        public DateTime Posted { get; set; }
        public int Upvotes { get; set; }
    }
}
