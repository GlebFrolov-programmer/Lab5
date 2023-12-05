using System.ComponentModel;

namespace person
{
    public class Person
    {
        public Person(string name, string surname, int age)
        {  
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            this.Status = "None status";
        }
        private static Person[] personArray = new Person[5]
        {
        new Person("Сергей","Бодров",31),
        new Person("Мария","Гришина", 24),
        new Person("Николай","Лобавнов",40),
        new Person("Елена","Маясова", 20),
        new Person("Анатолий","Смирнов",34)
        };
        private string name;
        private string surname;
        private int age;
        private string status;
        public string Status
        {
            get { return status; }
            set { if (value.Length == 0) value = "None status"; status = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { if (value.Length == 0) value = "Unknown"; surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { if (value.Length == 0) value = "Unknown"; name = value; }
        }
        public int Age
        {
            get { return age; }
            set { if (value < 0) value = 0; age = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"{name} {surname}, {age}, {status}";
        }
        public virtual bool Equals(Person other)
        {
            return this.name == other.name && this.surname == other.surname && this.age == other.age && this.status == other.status;
        }
        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = 30*hash + Surname.GetHashCode();
            hash = 30*hash + Age.GetHashCode();
            return hash;
        }

        public virtual Person RandomPerson()
        {
            Random rnd = new Random();
            return personArray[rnd.Next(0, 5)];
        }

        public virtual Person Clone()
        {
            return new Person(this.Name, this.Surname, this.Age);
        }

    }
}