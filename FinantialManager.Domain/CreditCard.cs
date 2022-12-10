using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain
{
    public class CreditCard
    {
        public string Id { get; }

        private string _name { get; set; }
        public string Name { get { return _name; } }

        private double _debt { get; set; }
        public double Debt { get { return _debt; } }

        public CreditCard(string id, string name)
        {
            Id= id;
            _name = name;
            _debt = 0;
        }

        public CreditCard(string id, string name, double debt)
        {
            Id = id;
            _name = name;
            _debt = debt;
        }

        public void DeductDebt (double value)
        {
            _debt -= value;
        }

        public void IncreaseDebt(double value)
        {
            _debt += value;
        }

    }
}
