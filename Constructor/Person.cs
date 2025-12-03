namespace Constructor
{
    internal class Person
    {
        public string Name;
        public int Age;
        // Constructor for å initialisere en Person
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static void Run()
        {
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");
        }
    }
}
