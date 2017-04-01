namespace Exercise2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ShoppingCart();
            
            sc.AddItem("Fjernsyn", 2, 5000);
            Console.WriteLine("Added Fjernsyn");
            sc.AddItem("Bil",1, 90000);
            Console.WriteLine("Added Bil");
            sc.SetCustomer(new Customer("Henrik", "hthomsen@ebay.com"));
            sc.NewCreditCard(CreditCardStatus.Accepted);
            
            sc.SubmitOrder();
            Console.ReadLine();
        }
    }
}
