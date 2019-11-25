using System;
namespace lesson3_StaticKeyword
{
    // Class tĩnh chỉ chứa các thành phần tĩnh (static variable, static method)
    // Không thể khai báo, khởi tạo 1 đối tượng thuộc lớp tĩnh để tránh lãng phí bộ nhớ
    // Mọi thứ đều được truy cập thông qua tên lớp
    
    public static class Color 
    {
        public static string cover_color;
        public static void showColor(string cv)        
        {            
            Console.WriteLine("Book color is" + cv);
        }

        // static constructor
        // Không được phép khai báo phạm vi truy cập
        // Constructor tĩnh chỉ được gọi 1 lần duy nhất
        // Constructor tĩnh chỉ chứa các thành phần tĩnh (static variable, static method)
        static Color()
        {
            cover_color = "black";
        }
    }
}