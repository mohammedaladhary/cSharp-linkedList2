namespace csharp_linked_lists
{
    internal class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, string gender, int age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
            if (other == null)
            {
                return 1;
            }
            if (other.Age == this.Age)
            {
                return 0;
            }
            if (other.Age > this.Age) 
            { 
                return -1;
            }
            return 1;
        }
    }
}