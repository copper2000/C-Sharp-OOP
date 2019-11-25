using System;

namespace lesson5_Polymorphism
{
    // 2 keyword: Virtual and Override

    // Virtual để khai báo 1 phương thức ảo (có thể ghi đè được)    
    // Override để đánh dấu phương thức ghi đè lên phương thức của lớp cha
    // Notice: Lớp con chỉ có thể ghi đè lên phương thức của lớp cha NẾU lớp cha có virtual (hoặc abstract)

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking...");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal BlackCat = new Cat();
            Animal BrownDog = new Dog();
            BlackCat.Speak();
            BrownDog.Speak();            
        }
    }
}
