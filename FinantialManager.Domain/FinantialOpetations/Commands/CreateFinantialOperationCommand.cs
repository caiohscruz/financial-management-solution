using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.FinantialOpetations.Commands
{
    public class CreateFinantialOperationCommand : FinantialOperationCommand
    {
        public CreateFinantialOperationCommand(string description, double amount, string originId, string targetId)
        {
            Description = description;
            Amount = amount;
            OriginId = originId;
            TargetId = targetId;
        }
    }
}
