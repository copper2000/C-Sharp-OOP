using System;

namespace lesson4_Inheritance
{
    class Animal
    {
        protected double Height;
        protected double Weight;
        protected static int Legs;
        
        // Nếu khai báo phạm vi là PRIVATE thì KHÔNG được kế thừa
        // Nếu khai báo phạm vi là PUBLIC VÀ PROTECTED thì ĐƯỢC kế thừa

        // phương thức khởi tạo (constructor) và phương thức hủy bỏ (~) không được kế thừa?

        // Được phép kế thừa constructor có tham số từ lớp cha thông qua từ khóa base
        public void Info()
        {
            Console.WriteLine("Height: {0}, Weight: {1}, Legs: {2}", this.Height, this.Weight, Animal.Legs);
        }

        public Animal()
        {

        }

        public Animal(int h, int w, int l)
        {
            Height = h;
            Weight = w;
            Legs = l;
        }
    }

    class Cat : Animal // kế thừa lớp cha Animal
    {
        public Cat()
        {
            Height = 10;
            Weight = 5;
            Legs = 4;
        }

        public Cat (int h, int w, int l) : base (h, w, l)
        {

        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Cat YellowCat = new Cat(11, 3, 4);
            YellowCat.Info();

            Cat BlackCat = new Cat(7, 8, 4);
            BlackCat.Info();

            Cat StandardCat = new Cat();
            StandardCat.Info();

            Animal SpecialCat = new Cat(7, 7, 7);
            SpecialCat.Info();
        }
    }
}
