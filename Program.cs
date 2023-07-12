namespace csharp_linked_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //List<string> list = new List<string>();
            //list.Add("k");
            //list.Add("b");
            //list.Add("c");
            //list.Remove("a");
            //list.Insert(0, "kl");
            //Console.WriteLine(list[0]);

            //foreach (string item in list) 
            //{
            //    Console.WriteLine(item);
            //}


            //List<Person> people = new List<Person>();
            //people.Add(new Person(1201,"Ahmed","Male",41));
            //people.Add(new Person(8553, "Salim", "Male",32));
            //people.Add(new Person(3745, "Emilia", "Female",63));

            //people.Sort();
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.Id + " " + person.Name 
            //        + " " + person.Gender + " " + person.Age);
            //}
            
            //---------------task1-list-------------------------------
            List<int> listBF = new List<int>() { 5, 2, 3, 1, 5, 1, 2, 6};
            List<int> listAF = removeDuplicate.RemoveDuplicates(listBF);

            // Print the updated list
            Console.Write("The updated list is: ");
            for (int i = 0; i < listAF.Count; i++)
            {
                Console.Write(listAF[i]);
                if (i < listAF.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}