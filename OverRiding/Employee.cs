namespace OverRiding
{
    public class Employee : Person
    {
        private double salary;
        private DateOnly hireDay;

        public Employee(string name, double salary, int year, int month, int day) : base(name)
        {
            this.salary = salary;
            hireDay = new DateOnly(year, month, day);
        }

        public double getSalary()
        {
            return salary;
        }

        public DateOnly getHireDay()
        {
            return hireDay;
        }
        public override string getDescription()
        {
            return string.Format("an employee with a slaray of {0:0.00}", salary);
        }

        public void raiseSalary(double byPercent)
        {
            double raise = salary * byPercent / 100;
            salary += raise;
        }
    }
}