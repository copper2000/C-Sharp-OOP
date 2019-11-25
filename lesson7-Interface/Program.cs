using System;

namespace lesson7_Interface
{
    // Interface là tập các thành phần chỉ có khai báo mà không có định nghĩa (giống abtract method trong Abtraction).
    // Interface được hiểu như một khuôn mẫu mà mọi thực thi (implement) nó đều phải tuân theo.

    // Các thành phần có thể là:
    // 1. Method.
    // 2. Property (get, set).
    // 3. Event (Advance C#).
    // 4. Indexers (Advance C#).

    // Đặc điểm (Feature) của Interface
    
    // 1. Chỉ chứa khai báo nhưng không cần định nghĩa (cũng không cần abtract keyword).
    // 2. Ghi đè không cần sử dụng override.
    // 3. Không được khai báo phạm vi truy cập (public, private, protected,..) cho interface (mặc định public).
    // 4. Interface không chứa các biến, kể cả const hay static. (Chỉ chứa property).
    // 5. Interface không có constructor và destructor.
    // 6. Các class có thể implement nhiều interface cùng 1 lúc (phương án thay thế đa kế thừa).
    // 7. Một Interface có thể kế thừa nhiều interface khác nhưng không thể kế thừa bất kỳ lớp nào.


    interface ISpeak
    {
       void Speak();                  
    }

    interface IEat
    {
        void Eat();
    }

    class Animal : ISpeak, IEat
    {
        public void Speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Eat();
            animal.Speak();        
        }
    }
}
