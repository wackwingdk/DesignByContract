namespace Exercise5
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var ht = new Person(new DateTime(1977,9,22),null, "Henrik Thomsen", Sex.Male );
            var hilda = new Person(new DateTime(1944, 3, 21), null, "Hilda Thomsen", Sex.Female);
            var harry = new Person(new DateTime(1950, 6, 16), null, "Harry Thomsen", Sex.Male);
            ht.SetFather(harry); 
            ht.SetMother(hilda);
            hilda.AddChild(ht);
            harry.AddChild(ht);
            Console.ReadLine();
        }
    }
}
