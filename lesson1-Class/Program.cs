using System;

namespace lesson1_Class
{

    // class Animal
    // {
    //     public int Weight;
    //     public int Height;
      
    //     public void Info()
    //     {
    //         Console.WriteLine("Hello, your pet's height is ", + Weight + " and weight is" + Weight);
    //     }

    // }

    class Dog 
    {
        public int Weight;
        public int Height;

        // constructor with no parameter
        public Dog()
        {
            Weight = 5;
            Height = 20;
        }

        // contructor with parameter
        public Dog(int h, int w)
        {
            Height = h;
            Weight = w;
        }

        public void Info()
        {
            Console.WriteLine("Hello, your pet's height is " + this.Weight + " and weight is " + this.Height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Animal Cat = new Animal();
            // Cat.Info();

            Dog Min = new Dog(4, 10);
            Min.Info();
            
        }

    }
}
