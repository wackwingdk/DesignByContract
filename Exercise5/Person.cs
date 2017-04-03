namespace Exercise5
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class Person
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public Sex Sex { get; set; }

        private Person Father { get; set; }

        private Person Mother { get; set; }

        public List<Person> Children { get; set; }


        void CheckValidPerson()
        {
            Debug.Assert(BirthDate != null && Name != null && Name != string.Empty);
            Debug.Assert(DeathDate == null || BirthDate < DeathDate.Value);
            Debug.Assert(Mother == null || BirthDate > Mother.BirthDate);
            Debug.Assert(Father == null || BirthDate > Father.BirthDate);
        }

        public Person(DateTime birthDate, DateTime? deathDate, string name, Sex sex)
        {
            BirthDate = birthDate;
            DeathDate = deathDate;
            Name = name;
            Sex = sex;
            Children = new List<Person>();
            CheckValidPerson();
        }

        public void SetMother(Person p)
        {
            Mother = p;
            Debug.Assert(Mother == p);
            Debug.Assert(p.Sex == Sex.Female);
        }

        public void SetFather(Person p)
        {
            Father = p;
            Debug.Assert(Father == p);
            Debug.Assert(p.Sex == Sex.Male);
        }

        public void AddChild(Person p)
        {
            Children.Add(p);
            p.CheckValidPerson();
            Debug.Assert(Children.Contains(p));
            Debug.Assert(Sex == Sex.Male || p.Mother == this);
            Debug.Assert(Sex == Sex.Female || p.Father == this);
        }
        
    }
}
