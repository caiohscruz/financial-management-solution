using FinantialManager.Domain.Core.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.Models
{
    public class CreditCard : PaymentMethod
    {
        public double Debt { get; set; }       

    }
}
