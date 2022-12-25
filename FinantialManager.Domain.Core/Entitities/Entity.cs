using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.Core.Entitities
{
    public abstract class Entity
    {
        public string Id { get; protected set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; protected set; } = DateTime.Now;
        public DateTime UpdatedAt { get; protected set; } = DateTime.Now;
        
    }
}
