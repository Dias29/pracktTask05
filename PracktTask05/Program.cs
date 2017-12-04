using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracktTask05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Init();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            

            Console.ReadLine();
        }
        static void Init()
        {
            Console.WriteLine("Введите строку не более 6 символов: ");
            string message = Console.ReadLine();
            if (message.Length > 6)
            {
                throw new Exception("Длина строки больше 6 символов");
            }


        }

       
    }
}
