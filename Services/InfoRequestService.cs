using System;
using UserView.Models;

namespace UserView.Services
{
    public class InfoRequestService
    {
        public Person GetPersonFromConsole()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter your group: ");
            string group = Console.ReadLine();

            int yearAtUniversity = GetValidYearFromConsole();
            Console.Write("Please enter your hobbies: ");
            string hobbies = Console.ReadLine();

            return new Person(name, surname, group, yearAtUniversity, hobbies);
        }

        private int GetValidYearFromConsole()
        {
            int yearAtUniversity;
            Console.Write("Please enter the year you started at university: ");
            while (!int.TryParse(Console.ReadLine(), out yearAtUniversity))
            {
                Console.Write("Invalid input. Please enter a valid year: ");
            }
            return yearAtUniversity;
        }
    }

}
