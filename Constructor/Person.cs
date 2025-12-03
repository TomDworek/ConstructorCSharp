namespace Constructor
{
    internal class Person
    {
        public string Name;
        public int Age;
        public string Sex;
        // Constructor for å initialisere en Person
        public Person(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
        public static void Run()
        {
            Person person1 = new Person("Alpha", 30, "F");
            Person person2 = new Person("Bravo", 25, "M");
            Console.WriteLine($"Navn: {person1.Name}, Alder: {person1.Age}, Sex: {person1.Sex}");
            Console.WriteLine($"Navn: {person2.Name}, Alder: {person2.Age}, Sex {person2.Sex}");
        }
    }
}
