using DOA.Models;
using DOA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOA.Controllers
{
    public class DOAController : Controller
    {


        private readonly IDayService _dayServiceNI;
        public DOAController(IDayService dayServiceNI)
        {
            _dayServiceNI = dayServiceNI;
        }

        public async Task<IActionResult> Index()
        {
            var allMyDaysNI = await _dayServiceNI.GetIncompleteDaysAsync();
            var modelNI = new DaysViewModel()
            {
                AllDaysFromVM = allMyDaysNI
            };

            return View(modelNI);
        }



    }
}
