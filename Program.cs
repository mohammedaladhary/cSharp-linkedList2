namespace csharp_linked_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Remove("a");
            list.Insert(0, "kl");
            Console.WriteLine(list[0]);

            list.Sort();
            foreach (string item in list) 
            {
                Console.WriteLine(item);
            }


            List<Person> people = new List<Person>();
            people.Add(new Person(1201,"Ahmed","Male",21));
            people.Add(new Person(8553, "Salim", "Male",32));
            people.Add(new Person(3745, "Emilia", "Female",63));

            people.Sort();
            foreach (Person person in people)
            {
                Console.WriteLine(person.Id + " " + person.Name 
                    + " " + person.Gender + " " + person.Age);
            }
        }
    }
}