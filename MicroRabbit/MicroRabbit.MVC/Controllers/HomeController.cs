using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroRabbit.MVC.Models;
using MicroRabbit.MVC.Services;
using MicroRabbit.MVC.Models.DTO;

namespace MicroRabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReceiverService _receiverService;

        public HomeController(IReceiverService receiverService)
        {
            _receiverService = receiverService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]

        public async Task<IActionResult> Receiver(ReceiverViewModel model)
        {
            ReceiverDto receiverDto = new ReceiverDto()
            {
                FirstName  =  model.FirstName,
                LastName   =  model.LastName,
                PhoneNumber =  model.PhoneNumber,
                EventLocation = model.EventLocation,
                Address =  model.Address,
                TotalAmount  =  model.TotalAmount

        };
            await _receiverService.Receiver(receiverDto);
            return View("Index");
        }

    }
}
