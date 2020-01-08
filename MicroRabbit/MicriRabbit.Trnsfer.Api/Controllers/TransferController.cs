using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Cataring.Application.Models;
using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicriRabbit.Trnsfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        // GET api/reansfer
        [HttpGet]
        public ActionResult<IEnumerable<OrderTransfer>> Get()
        {
            return Ok(_transferService.GetOrderTransfers());
        }    
    }
}
