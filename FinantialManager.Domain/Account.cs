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
        public double Balance { get { return _balance; } }

        public Account(string id, string name )
        {
            Id = id;
            _name = name;
            _balance = 0;
        }
        public Account(string id, string name, double balance)
        {
            Id = id;
            _name = name;
            _balance = balance;
        }

        public void UpdateName(string newName)
        {
            _name = newName;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount; 
        }

    }
}
