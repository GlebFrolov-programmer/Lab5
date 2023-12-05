using person;
using student;
using teacher;

Console.WriteLine("Test class Person");
Person p1 = new Person("Артём", "Абрамян", 21);
Person p2 = new Person("Ольга", "Ионова", 23);
p1.Print();
Console.WriteLine(p1.Equals(p2));
Person p3 = p1.Clone();
p3.Print();
Person p4 = p1.RandomPerson();
p4.Print();
Console.WriteLine(p3.GetHashCode());
Console.WriteLine(p3.ToString());
Console.WriteLine();


Console.WriteLine("Test class Student");
Student s1 = new Student("Егор", "Логутов", 21, 4);
Student s2 = s1.Clone();
s1.Print();
Console.WriteLine(s1.Equals(s2));
p3.Print();
Student s3 = s1.RandomPerson();
s3.Print();
Console.WriteLine(s2.GetHashCode());
Console.WriteLine(s2.ToString());
Console.WriteLine();


Console.WriteLine("Test class Teacher");
Teacher t1 = new Teacher("Егор", "Логутов", 28);
Teacher t2 = t1.Clone();
t1.Print();
Console.WriteLine(t1.Equals(t2));
t2.Print();
Teacher t3 = t1.RandomPerson();
t3.Print();
Console.WriteLine(t2.GetHashCode());
Console.WriteLine(t2.ToString());