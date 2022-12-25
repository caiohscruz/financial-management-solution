using FinantialManager.Domain.FinantialOpetations.Models;

namespace FinantialManager.Domain.FinantialOpetations.Events
{
    public class FinantialOperationCreatedEvent
    {
        private event EventHandler<FinantialOperationCreatedEventArgs> Handlers;

        public void Fire(FinantialOperation finantialOperation)
        {
            var evt = new FinantialOperationCreatedEventArgs()
            {
                Id = finantialOperation.Id,
                OriginId = finantialOperation.OriginId,
                TargetId = finantialOperation.TargetId
            };

            Handlers?.Invoke(this, evt);
        }

    }
}
