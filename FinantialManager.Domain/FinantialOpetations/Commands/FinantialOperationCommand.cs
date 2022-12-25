using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.FinantialOpetations.Commands
{
    public class FinantialOperationCommand : Command
    {
        public string Id { get; protected set; } = string.Empty;
        public string Description { get; protected set; } = string.Empty;
        public double Amount { get; protected set; }
        public string OriginId { get; protected set; } = string.Empty;
        public string TargetId { get; protected set; } = string.Empty;
    }
}
