using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_Practical_2.Models;

namespace INF272_Practical_2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            List<PeopleModel> peoplelist = new List<PeopleModel> 
            {
                new PeopleModel()
                {
                    FirstName = "Itumeleng",
                    LastName = "Mokgohloa",
                    Age = 22,
                    IsAlive = true,
                    myLink = "~/HTML/Person1.html",

                },

                new PeopleModel()
                {
                    FirstName = "Bohlale",
                    LastName = "Thosago",
                    Age = 22,
                    IsAlive = true,
                    myLink = "~/HTML/Person2.html",

                },

                new PeopleModel()
                {
                    FirstName = "Nicholas",
                    LastName = "Madingwane",
                    Age = 24,
                    IsAlive = true,
                    myLink = "~/HTML/Person3.html",

                },

                new PeopleModel()
                {
                    FirstName = "Lerato",
                    LastName = "Maja",
                    Age = 20,
                    IsAlive = true,
                    myLink = "~/HTML/Person4.html",

                },

                new PeopleModel()
                {
                    FirstName = "Yolanda",
                    LastName = "Nkambule",
                    Age = 21,
                    IsAlive = true,
                    myLink = "~/HTML/Person5.html",

                },
            };

            return View(peoplelist); 
        }

    }
}