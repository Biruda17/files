using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @$"C:\Users\ivan7\OneDrive\Рабочий стол\test.txt";
            Creation(ref path);
            logic(ref path);
            Console.ReadKey(true);
        }
        public static void Creation(ref string path)
        {     
            string[] strings =
            {
                "Сколько пальцев у человека?","20",
                "Сколько глаз у человека?", "2",
                "Сколько ног у человека?","2",
                "Сколько лап у кошки?","4",
                "Какую оценку мне поставят?","5"
            };
            var ultimate = File.Create(path);
            ultimate.Close();
            File.WriteAllLines(path, strings);
        }
        public static void logic(ref string path)
        {
            int vvod = 0;
            int reader = 0;
            int calc = 0;
            string[] massiv =File.ReadAllLines(path);
            for(int i=0;i<massiv.Length;i++)
            {
                Console.WriteLine(massiv[i]);
                vvod = int.Parse(Console.ReadLine());
                reader = Convert.ToInt32(massiv[i+1]);
                if(vvod==reader)
                {
                    Console.WriteLine("Правильный ответ");
                    calc++;
                    Console.WriteLine("Нажмите кнопку чтобы перейти к следующему вопросу");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Вы ответили неправильно\nПравильный ответ: {reader}\nНажмите кнопку чтобы перейти к следующему вопросу");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                i++;
            }
            Console.WriteLine($"Число правильных ответов:{calc}");
        }
    }   
}