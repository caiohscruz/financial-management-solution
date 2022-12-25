using FinantialManager.Domain.Core.Entitities;
using FinantialManager.Domain.PaymentMethods;

namespace FinantialManager.Domain.FinantialOpetations.Models
{
    public class FinantialOperation : Entity
    {
        public string Description { get; set; } = string.Empty;

        public double Amount { get; set; } = 0;

        //TODO: Add Date and Processed properties

        public string OriginId { get; set; } = string.Empty;

        public string TargetId { get; set; } = string.Empty;


    }
}
