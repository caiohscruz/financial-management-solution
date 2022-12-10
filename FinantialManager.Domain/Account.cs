using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain
{
    public class Account
    {
        public string Id { get; }

        private string _name { get; set; }
        public string Name { get { return _name; } }

        private double _balance { get; set; }
        public double Balance { get; }

        public Account(string id, string name )
        {
            Id = id; // change to UUID 
            _name = name;
            _balance = 0;
        }

        public void UpdateName(string newName)
        {
            _name = newName;
        }

        public void Credit(double value)
        {
            _balance += value;
        }

        public void Debit(double value)
        {
            _balance -= value; 
        }

    }
}
