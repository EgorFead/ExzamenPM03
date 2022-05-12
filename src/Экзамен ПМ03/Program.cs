using System;
using System.IO;
namespace ConsoleApp2
{
    struct Trip
    {
        public int prodoljitelnost;
        public int price;
        public int size_turist_group;
    }
    class TouristicOperator
    {
        static void Main(string[] args)
        {
            Trip obj = new Trip();
            int n, m = 0;
            Console.Write("Введите размер массива = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ошибка ввода! Введитее ещё раз = ");
            }
            int[] mas = new int[n * 4];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите продолжительность в часах = ");
                while (!int.TryParse(Console.ReadLine(), out obj.prodoljitelnost))
                {
                    Console.Write("Ошибка ввода! Введитее ещё раз = ");
                }
                mas[m] = obj.prodoljitelnost;
                m++;
                Console.Write("Введите количество туристов = ");
                while (!int.TryParse(Console.ReadLine(), out obj.size_turist_group))
                {
                    Console.Write("Ошибка ввода! Введитее ещё раз = ");
                }
                mas[m] = obj.size_turist_group;
                m++;
                Console.Write("Введите цену = ");
                while (!int.TryParse(Console.ReadLine(), out obj.price))
                {

                }
                mas[m] = obj.price;
                m++;
            }
            StreamWriter y = new StreamWriter("File.txt");
            m = 0;
            for (int i = 0; i < n; i++)
            {
                y.WriteLine("Продолжительность в часах: " + mas[m]); m++;
                y.WriteLine("Количество туристов: " + mas[m]); m++;
                y.WriteLine("Цена: " + mas[m]); m++;
            }
            y.Close();
        }
    }


}