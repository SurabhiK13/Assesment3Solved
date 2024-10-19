namespace Q1_Person_
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
    public class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string name = "";
            foreach (var p in person)
            {
                name +=$"{p.Name} {p.Address}" ;
            }
            return name;
        }
        public double Average(IList<Person> person)
        {
            double totalAge = 0;
            double count = 0;
            foreach (var p in person)
            {
                totalAge += p.Age;
                count++;
            }
            return totalAge / count;
        }
        public int Max(IList<Person> person)
        {
            int maxAge = 0;
            foreach (var p in person)
            {
                if (maxAge < p.Age)
                {
                    maxAge = p.Age;
                }
            }
            return maxAge;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Person> lp = new List<Person>();
            lp.Add(new Person { Name = " Aarya", Address = " A2101 ", Age = 69 });
            lp.Add(new Person { Name = "Daniel", Address = " D104 ", Age = 40 });
            lp.Add(new Person { Name = "Ira", Address = " H801 ", Age = 25 });
            lp.Add(new Person { Name = "Jennifer", Address = " I1704", Age = 33 });

            PersonImplementation imp = new PersonImplementation();
            Console.WriteLine("People Details :" + imp.GetName(lp));
            Console.WriteLine("Average Age : "  + imp.Average(lp));
            Console.WriteLine("Maximum Age : " + imp.Max(lp));


        }
    }
}
