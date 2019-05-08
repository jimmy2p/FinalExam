using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Data;
using FinalExam.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleRepository _vehicleRepository;
        public HomeController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public IActionResult Index()
        {
            return View(_vehicleRepository.GetAll());
        }
    }
}