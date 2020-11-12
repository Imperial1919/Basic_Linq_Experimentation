using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Video_Game_Titles = new List<string> { "Call of Duty World at War", "Locomotion", "Railroad Tycoon III", "Europa Universalis IV", "Crusader Kings III", "Hearts of Iron Darkest Hour" };

            var OrderByLength = Video_Game_Titles.OrderBy(titles => titles.Length);

           foreach(var value in OrderByLength)
            {
                Console.WriteLine(value);
            }


        }
    }
}
