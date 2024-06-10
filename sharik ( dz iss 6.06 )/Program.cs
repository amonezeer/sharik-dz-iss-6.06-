using System;

namespace ResumePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResume();
        }

        static void PrintResume()
        {
            string name = "Юсыпив Александр";
            string title = "Студент-программист";
            string contactInfo = "Email: yusypiv07@gmail.com\nТелефон: +380 98 059 32 91";
            string summary = "Талантливый студент с сильным интересом к программированию и разработке программного обеспечения";
            string[] skills = { "C++", "ООП", "UML диаграммы", "Паттерны проектирования" };
            string[] education = {
                "Школа: Усатовский Лицей\nПериод: Сентябрь 2013 - Май 2024",
                "Курсы: Академия ITStep\nПериод: Ноябрь 2022 - Настоящее время "
            };

            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("                       Резюме");
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Имя: {name}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Должность: {title}");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Контактная информация:");
            Console.ResetColor();
            Console.WriteLine(contactInfo);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Краткое описание:");
            Console.ResetColor();
            Console.WriteLine(summary);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Навыки:");
            Console.ResetColor();
            foreach (var skill in skills)
            {
                Console.WriteLine($"- {skill}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Образование:");
            Console.ResetColor();
            foreach (var edu in education)
            {
                Console.WriteLine(edu);
            }
        }
    }
}
