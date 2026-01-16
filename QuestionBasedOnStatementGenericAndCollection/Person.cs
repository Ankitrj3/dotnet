namespace PersonImpl
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
    }
    public class PersonImplemaintation
    {
        public string GetName(IList<Person> person)
        {
            string result = "";
            foreach (Person p in person)
            {
                result += $"{p.Name} {p.Address} ";
            }
            return result;
        }
        public double Average(IList<Person> person)
        {
            double avg = 0;
            int count = 0;
            foreach (Person p in person)
            {
                avg += p.Age;
                count++;
            }
            return avg / count;
        }
        public int Max(IList<Person> person)
        {
            int max = int.MinValue;
            int secondHighest = int.MinValue;
            foreach (Person p in person)
            {
                if (p.Age > max)
                {
                    secondHighest = max;
                    max = p.Age;
                }
                else if (p.Age > secondHighest && p.Age != max)
                {
                    secondHighest = p.Age;
                }
            }
            return secondHighest;
            
        }
    }
}