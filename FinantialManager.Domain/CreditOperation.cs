namespace FinantialManager.Domain
{
    public class CreditOperation
    {
        public string Id { get; }

        private string _name { get; set; }
        public string Name { get { return _name; } }

        private double _amount { get; set; }
        public double Amount { get { return _amount; } }

        private Account _target { get; set; }
        public Account Target { get { return _target; } }

        public CreditOperation(string id, string name, double amount, Account target)
        {
            Id = id;
            _name = name;
            _amount = amount;
            _target = target;
        }

        public void UpdateName(string name)
        {
            _name= name;
        }

        public void UpdateAmount(double amount)
        {
            _amount = amount;
        }

        public void UpdateTarget(Account target)
        {
            _target = target;
        }
    }
}
