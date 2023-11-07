using System;
namespace Inheritence {
    class Base {
        private string name;
        public int age;
        protected bool gender;
        internal double cgp;

        Inheritence() {
            name = "N/A";
            age = 0;
        }
    }
    class Derived : Base {
        
    }
}