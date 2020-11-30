using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_6
{
    public class Triad
    {
        public double num1;
        public double num2;
        public double num3;

        //Первое число
        public double Num1
        {
            get
            {
                return num1;
            }
            set
            {
                if (value >= 0) num1 = value;

            }
        }

        //Второе число
        public double Num2
        {
            get
            {
                return num2;
            }
            set
            {
                if (value >= 0) num2 = value;
            }
        }

        //Третье число
        public double Num3
        {
            get
            {
                return num3;
            }
            set
            {
                if (value >= 0) num3 = value;
            }
        }

        public Triad(double num1, double num2, double num3)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
        }

        //Конструктор 
        public Triad()
        {
            Num1 = 0;
            Num2 = 0;
            Num3 = 0;
        }

        //Заполнение случайными значениями
        public void SetParams()
        {
            Random rand = new Random();//Создание объекта rand
            num1 = rand.Next(0, 100);
            num2 = rand.Next(0, 100);
            num3 = rand.Next(0, 100);
        }

        //Вычисление суммы чисел триады
        //Возвращает сумму чисел 
        public double Summ()
        {
            return num1 + num2 + num3;
        }

        //Задать одинаковые значения
        public void SetParams(int i)
        {
            Num1 = i;
            Num2 = i;
            Num3 = i;
        }
        public void SetParams(int a1, int a2, int a3)
        {
            Num1 = a1;
            Num2 = a2;
            Num3 = a3;
        }

        //Сравнение на равенство/неравенство чисел первой триады
        public static bool operator true(Triad triada1)
        {
            if (triada1.num1 == triada1.num2 && triada1.num1 == triada1.num3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Triad triada1)
        {
            if (triada1.num1 != triada1.num2 || triada1.num1 != triada1.num3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Полное сравнение на равенство/неравенство чисел первой и второй триады
        public static bool operator ==(Triad triada1, Triad triada2)
        {
            if (triada1.num1 == triada2.num1 && triada1.num2 == triada2.num2 && triada1.num3 == triada2.num3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Triad triada1, Triad triada2)
        {
            if (triada1.num1 != triada2.num1 || triada1.num2 != triada2.num2 || triada1.num3 != triada2.num3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    //
    public class Triangle : Triad
    {
        public double num1;//сторона АВ
        public double num2;//сторона ВС
        public double num3;//сторона АС
        public double angle1;
        public double angle2;
        public double angle3;

        //Конструктор с начальными значениями
        public Triangle()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
        }

        //Конструктор 
        public Triangle(double Num1, double Num2, double Num3) : base(Num1,Num2,Num3)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
        }
   
    //Вычисление углов треугольника
    public void Corner()
        {
            //вычисляем арккосинус угла и округляем до 0 цифр после запятой
            angle1 = Math.Round(Math.Acos(((num2 * num2) + (num3 * num3) - (num1 * num1)) / (2 * num2 * num3)) * 180 / Math.PI, 0);
            angle2 = Math.Round(Math.Acos(((num1 * num1) + (num3 * num3) - (num2 * num2)) / (2 * num1 * num3)) * 180 / Math.PI, 0);
            angle3 = Math.Round(180 - (angle1 + angle2), 0);
           
        }

        //Вычисление площади треугольника
        public double Ar()
        {
            double p = (num1 + num2 + num3) / 2;
            double area = Math.Sqrt(p * (p - num1) * (p - num2) * (p - num3));
            double x = Math.Round(area, 2);
            return x;
        }
    }
}

