using Tyuiu.MitrofanovaPV.Sprint1.Task6.V13.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint1.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Митрофанова П.В. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Митрофанова Полина Викторовна | ПИНб-25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает задачу и печатает результат          *");
            Console.WriteLine("* на экране.                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ds.CheckWordsAlphabet(str) == true)
            {
                Console.WriteLine("Буквы упорядочены по алфавиту");
            }
            else
            {
                Console.WriteLine("Буквы не упорядочены");
            }
                Console.ReadLine();
        }
    }
}