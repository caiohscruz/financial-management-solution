using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.FinantialOpetations.Events
{
    public class FinantialOperationCreatedEventArgs : EventArgs
    {
        public string Id { get; set; }
        public string OriginId { get; set; }
        public string TargetId { get; set; }
    }
}
