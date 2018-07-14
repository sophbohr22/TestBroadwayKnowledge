using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BroadwayKnowledgeTest.Controllers
{
    public class QuizTopicsController : Controller
    {
        public IActionResult Actors()
        {
            return View();
        }

        public IActionResult Playbills()
        {
            return View();
        }

        public IActionResult Songs()
        {
            return View();
        }

        public IActionResult Theatres()
        {
            return View();
        }

        public IActionResult Tonys()
        {
            return View();
        }

    }
}