using FinantialManager.Domain.FinantialOpetations.Commands;
using FinantialManager.Domain.FinantialOpetations.Events;
using FinantialManager.Domain.FinantialOpetations.Interfaces;
using FinantialManager.Domain.FinantialOpetations.Models;
using MediatR;

namespace FinantialManager.Domain.FinantialOpetations.CommandHandlers
{
    public class CreateFinantialOperationCommandHandler : IRequestHandler<CreateFinantialOperationCommand, bool>
    {
        private readonly IFinantialOperationRepository _finantialOperationRepository;

        public CreateFinantialOperationCommandHandler(IFinantialOperationRepository finantialOperationRepository)
        {
            _finantialOperationRepository = finantialOperationRepository;
        }

        public Task<bool> Handle(CreateFinantialOperationCommand request, CancellationToken cancellationToken)
        {
            var finantialOperation = new FinantialOperation()
            {
                Description = request.Description,
                Amount = request.Amount,
                OriginId= request.OriginId,
                TargetId = request.TargetId
            };

            _finantialOperationRepository.Create(finantialOperation);

            

            return Task.FromResult(true);
        }

        
    }
}
