using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Cataring.Domain.Models;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDBContext _Ctx;

        public TransferRepository(TransferDBContext Ctx)
        {
            _Ctx = Ctx;
        }

        public IEnumerable<OrderTransfer> GetOrderTransfers()
        {
            return _Ctx.OrderTransfers;
        }
    }
}
