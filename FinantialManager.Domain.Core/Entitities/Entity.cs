using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.Core.Entitities
{
    public abstract class Entity
    {
        public string Id { get; protected set; }
        protected Entity() { 
            Id= Guid.NewGuid().ToString();
        }
        protected Entity(string id)
        {
            Id= id;
        }
    }
}
