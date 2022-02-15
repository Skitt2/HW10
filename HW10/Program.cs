using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число градусов ");
            int valueGradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число угловых минут ");
            int valueMin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число угловых секунд ");
            int valueSec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(valueGradus, valueMin, valueSec);
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        public int Gradus
        {
            set
            {
                if (value <= 360 & value >= 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение не может быть больше 360");
                }
            }
            get
            {
                return gradus;
            }
        }
        int min;
        public int Min
        {
            set
            {
                if (value < 60 & value >= 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение не может быть больше 60 и меньше нуля");
                }
            }
            get
            {
                return min;
            }
        }
        int sec;
        public int Sec
        {
            set
            {
                if (value < 60 & value >=0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение не может быть больше 60 и меньше нуля");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            Console.WriteLine("Угол в радианах равен {0}",(Gradus+Min*0.017+Sec*0.00028)/57.325);
        }
    }

}
