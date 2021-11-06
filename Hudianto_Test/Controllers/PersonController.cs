using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hudianto_Test.Models;
using Hudianto_Test.BusinessLayer;

namespace Hudianto_Test.Controllers
{
    public class PersonController : Controller
    {        
        // GET: PersonController

        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(Person person)
        {
            BOCalculate bOCalculate = new BOCalculate();

            double avg = bOCalculate.Find(person);

            PersonBindingModel personBindingModel = new PersonBindingModel()
            {
                AvgKilled = avg.ToString()
            };

            return View("~/Views/Person/View.cshtml",personBindingModel);
        }

    }
}
