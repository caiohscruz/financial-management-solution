using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain
{
    public class DebitOperation
    {
        public string Id { get; }

        private string _name { get; set; }
        public string Name { get { return _name; } }

        private double _value { get; set; }
        public double Value { get { return _value; } }

        private Account _target { get; set; }
        public Account Target { get { return _target; } }

        public DebitOperation(string id, string name, double value, Account target)
        {
            Id = id;
            _name = name;
            _value = value;
            _target = target;
        }

        public void UpdateName(string name)
        {
            _name = name;
        }

        public void UpdateValue(double value)
        {
            _value = value;
        }

        public void UpdateTarget(Account target)
        {
            _target = target;
        }
    }
}
