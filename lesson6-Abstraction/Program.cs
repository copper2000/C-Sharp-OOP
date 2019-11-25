using System;

namespace lesson6_Abstraction
{
    // Abtraction

    // keyword: abstract
    // từ khóa abtract dùng để khai báo 1 lớp trừu tượng (abstract class) hoặc 1 phương thức thuần ảo (abtract method)
    // phương thức thuần ảo bắt buộc phải override

    public abstract class Car
    {
        public abstract void EngineStart();  
        public abstract bool isLightTurnOn();                      
    }

    class Honda : Car
    {
        public override void EngineStart()
        {
            Console.WriteLine("Honda engine start...");
        }
        public override bool isLightTurnOn()
        {
            bool onoff = true;            
            Console.WriteLine("Light: "+ onoff);
            return onoff;
        }
    }

    class Ford : Car
    {
        public override void EngineStart()
        {
            Console.WriteLine("Ford engine start...");
        }
        public override bool isLightTurnOn()
        {
            bool onoff = false;            
            Console.WriteLine("Light: "+ onoff);
            return onoff;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car Civic = new Honda();
            Car Ranger = new Ford();

            Civic.EngineStart();
            Ranger.EngineStart();

            Civic.isLightTurnOn();
            Ranger.isLightTurnOn();
        }
    }
}
