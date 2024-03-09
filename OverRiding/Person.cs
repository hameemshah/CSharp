namespace OverRiding
{
    public abstract class Person
    {
        public abstract string getDescription();
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return GetType().Name + "@" + getName();
        }
    }
}