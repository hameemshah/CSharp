namespace OverRiding
{
    public class Student : Person
    {
        private string major;
        public Student(string name, string major) : base(name)
        {
            this.major = major;
        }

        public override string getDescription()
        {
            return "a student majoring in " + major;
        }
    }
}