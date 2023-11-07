using System;
namespace Constructor {

    class Test {
        public int num;
        public Test() {
            num = 100;
        }
    }
    class Constructor {
        static Constructor() {
            Console.WriteLine("Static constructor called.");
        }

        public static void Main(string[] args) {
            Test test = new Test();
            Console.WriteLine(test.num);
        }
    }
}