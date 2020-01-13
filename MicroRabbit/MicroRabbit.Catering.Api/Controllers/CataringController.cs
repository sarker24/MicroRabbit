using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Cataring.Application.Interfaces;
using MicroRabbit.Cataring.Application.Models;
using MicroRabbit.Cataring.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Catering.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CataringController : ControllerBase
    {
        private IOrderService _orderService;

        public CataringController(IOrderService orderService)
        {
            _orderService = orderService;

        }

        //public CataringController()
        //{

        //}
        // GET api/Catering
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return Ok(_orderService.GetOrders());
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderTransfer orderTransfer)
        {
            _orderService.Transfer(orderTransfer);
            return Ok(orderTransfer);
        }


    }
}
