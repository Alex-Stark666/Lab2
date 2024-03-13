using System;

class Program
{
    static void Main()
    {
        //Лабораторная работа 2, Календарь
        //При запуске программы пользователю предлагается справочная информация по использованию.
        //Далее предлагается ввести команду, позволяющую выполнить одно из действий:
        //проверить, является ли введенный год високосным
        //рассчитать длительность интервала между двумя датами
        //вывести названия дня недели по введенной дате.
        //Предполагается, что программа оперирует григорианским календарём.

        Console.WriteLine("Welcome to the Year Checker!");
        Console.WriteLine("Here are some options you can use:");
        Console.WriteLine("1: Check if the entered year is a leap year");
        Console.WriteLine("2: Calculate the length of the interval between two dates");
        Console.WriteLine("3: Output the names of the day of the week according to the entered date");
        Console.WriteLine("4: Exit the program");

        while (true)
        {
            Console.WriteLine("Please enter the number of your option:");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Please enter the year you would like to check:");
                int year = Convert.ToInt32(Console.ReadLine());

                bool isLeapYear = false;

                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            isLeapYear = true;
                        }
                    }
                    else
                    {
                        isLeapYear = true;
                    }
                }

                if (isLeapYear)
                {
                    Console.WriteLine($"The year {year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"The year {year} is not a leap year.");
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("Please enter the first date (dd/mm/yyyy):");
                DateTime date1 = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second date (dd/mm/yyyy):");
                DateTime date2 = DateTime.Parse(Console.ReadLine());

                TimeSpan difference = date2 - date1;

                Console.WriteLine($"The length of the interval between the two dates is {difference.TotalDays} days.");
            }
            else if (input == "3")
            {
                Console.WriteLine("Please enter the date (dd/mm/yyyy):");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"The name of the day of the week for the entered date is {date.DayOfWeek}.");
            }
            else if (input == "4")
            {
                Console.WriteLine("Thank you for using the Year Checker! Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}