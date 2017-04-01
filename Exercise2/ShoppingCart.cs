namespace Exercise2
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public class ShoppingCart
    {
        private List<ShoppingCartItem> _items;
        public Customer Customer { get; set; }
        public decimal TotalPrice = 0;
        public CreditCard CreditCard { get; set; }

        [ContractInvariantMethod]
        void ItemsMustNotBeNull()
        {
            Contract.Invariant(_items != null);
        }

        [ContractInvariantMethod]
        void TotalPriceMustNotExceed()
        {
            Contract.Invariant(TotalPrice <= 100000);
        }

        public ShoppingCart()
        {
            _items = new List<ShoppingCartItem>();
        }

        public void AddItem(string name, int quantity, decimal price)
        {
            Contract.Requires<ArgumentOutOfRangeException>(quantity > 0 && name != null);
            Contract.Ensures(_items.Count == Contract.OldValue(_items.Count) + 1);
            Contract.Ensures(TotalPrice == Contract.OldValue(TotalPrice) + (quantity * price));
            var shoppingCartItem = new ShoppingCartItem(name, quantity, price);
            _items.Add(shoppingCartItem);
            TotalPrice += quantity*price;
        }

        public void SetCustomer(Customer c)
        {
            Contract.Requires(c!=null);
            Contract.Ensures(Customer == c);
            Customer = c;
        }

        [Pure]
        public int GetNumberOfItems()
        {
            Contract.Ensures( Contract.Result<int>() == _items.Count);
            return _items.Count;
        }

        public void NewCreditCard(CreditCardStatus status)
        {
            Contract.Requires(GetNumberOfItems() > 0);
            Contract.Ensures(CreditCard != null && CreditCard.Status == status);
            CreditCard = new CreditCard {Status = status};
        }

        public void SubmitOrder()
        {
            Contract.Requires(CreditCard != null && CreditCard.Status == CreditCardStatus.Accepted);
            Contract.Requires(Customer.Name != String.Empty && Customer.Email != string.Empty);
            Contract.Requires(GetNumberOfItems()>0); 
            _items.Clear();     
        }
    }

    public class ShoppingCartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ShoppingCartItem(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

    public class Customer
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class CreditCard
    {
        public CreditCardStatus Status { get; set; }
    }

    public enum CreditCardStatus
    {
        Unknown, Accepted, Rejected
    }



}
