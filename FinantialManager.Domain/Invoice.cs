using System.Collections.ObjectModel;

namespace FinantialManager.Domain
{
    public class Invoice
    {
        public string Id { get; }

        private string _name { get; set; }
        public string Name { get { return _name; } }

        private double _total { get; set; }
        public double Total { get { return _total; } }
        private List<DebitOperation> _itens { get; set; }
        public ReadOnlyCollection<DebitOperation>? Itens { get { return _itens.AsReadOnly(); } }

        private CreditCard _origem { get; set; }
        public CreditCard Origem { get { return _origem; } }

        private bool _pendent { get; set; }
        public bool Pendent { get { return _pendent; } }

        public Invoice(string id, string name, double value, bool pendent)
        {
            Id = id;
            _name = name;
            _total = value;
            _itens = new List<DebitOperation>();
            _pendent= pendent;
        }

        public Invoice(string id, string name, double value, List<DebitOperation> itens, bool pendent)
        {
            Id = id;
            _name = name;
            _total = value;
            _itens = itens;
            _pendent = pendent;
        }

        public void AddItem(DebitOperation item)
        {
            _itens.Add(item);
            _total = +item.Value;
        }

        public void RemoveItem(DebitOperation item)
        {
            // when item is not present
            _itens.Remove(item);
            _total =- item.Value;
        }

        public void PayOff()
        {
            _pendent= false;
        }

        public void CancelPayment()
        {
            _pendent= true;
        }
    }
}
