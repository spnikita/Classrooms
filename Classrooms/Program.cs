using System;
using System.Collections.Generic;
using System.Linq;

namespace Classrooms
{
    class Program
    {
        /// <summary>
        /// Список классов
        /// </summary>
        private static readonly Classroom[] Classes = new[]
        {
            new Classroom
            {
                Students = { "Evgeniy", "Sergey", "Andrew" },
            },
            new Classroom
            {
                Students = { "Anna", "Viktor", "Vladimir" },
            },
            new Classroom
            {
                Students = { "Bulat", "Alex", "Galina" },
            }
        };

        static void Main(string[] args)
        {
            var allStudents = GetAllStudents(Classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadKey();
        }

        /// <summary>
        /// Получить список всех учеников всех классов
        /// </summary>
        /// <param name="classes">Классы</param>
        /// <returns>Список всех учеников всех классов в одном списке</returns>
        private static ICollection<string> GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(el => el.Students).ToArray();
        }
    }
}
