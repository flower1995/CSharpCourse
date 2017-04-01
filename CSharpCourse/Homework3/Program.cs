using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework3
{
    class Writesprint1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string writestring = Console.ReadLine();

            string output = new string(writestring.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Перевернутая строка:{0}", output);

            int letscountnumber = writestring.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Количество введенных слов в строке: {0}", letscountnumber);

            writestring = writestring.Replace(" ", string.Empty);

            bool b = true;
            for (int i = 0; i < writestring.Length / 2; i++)
            {
                if (writestring[i] != writestring[writestring.Length - i - 1])
                {
                    b = false;
                }

                Console.WriteLine(((b) ? "является" : "не является") + " палиндромом");
                Console.ReadKey();
            }
        }
    }
}



