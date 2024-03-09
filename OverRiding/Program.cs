namespace OverRiding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Person[] people = new Person[2];
            
            // //fill the people array with Student and Employee objects
            // people[0] = new Employee("Harry Hacker", 5000, 1989, 10, 1);
            // people[1] = new Student("Maria Morris", "computer science");

            // //print the name and descriptions of all person objects
            // foreach (var p in people)
            //     Console.WriteLine(p.getName() + ", " + p.getDescription());
            Object obj = new Employee("Harry Hacker", 3500,199,1,1);
            Employee e = (Employee) obj;
            Student s = new Student("Gorge","cs");
            // Console.WriteLine(e.getName() + ", " + e.getDescription());
            Console.WriteLine(s);
        }
    }
}