using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackOverflowLab.Models;

namespace StackOverflowLab.Controllers
{
    public class StackController : Controller
    {
        public IActionResult Questions()
        {
            List<Questions> inquiries = DAL.GetAllQuestions();
            return View(inquiries);
        }

        public IActionResult QuestionsList()
        {
            List<Questions> quests = DAL.GetAllQuestions();
            return View(quests);
        }

        public IActionResult AskAQuestion()
        {
            return View();
        }
        public IActionResult SaveQuestion(Questions quest)
        {
            DAL.AddAQuestion(quest);
            return Redirect("/Questions");
        }
    }
}
