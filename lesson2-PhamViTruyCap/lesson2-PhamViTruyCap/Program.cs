using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_PhamViTruyCap
{
    class Student // mặc định là internal
    {
        private string id; // mặc định là private
        private string name;
        private double mathScore;
        private double historyScore;
        private double physicsScore;

        public double MathScore
        {
            // Thuộc tính truy vấn get
            get
            {
                return mathScore;
            }

            // Thuộc tính cập nhật set
            set
            {
                if (value <= 10 && value >= 0)
                {
                    mathScore = value;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }

        // CTRL + R + E. generate thuộc tính truy vấn get và thuộc tính cập nhật get
        public double HistoryScore
        {
            get
            {
                return historyScore;
            }

            set
            {
                if (value <= 10 || value >= 0) historyScore = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double PhysicsScore
        {
            get
            {
                return physicsScore;
            }

            set
            {
                physicsScore = value;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.MathScore = 14;
            Console.Write("Math Score = " + st1.MathScore);         
            Console.ReadKey();
        }
    }
}
