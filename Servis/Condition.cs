using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10.Servis
{
    public static class Condition
    {
        public static void Сondition(this Start start)
        {
            Console.WriteLine("Car search by cost.");

            int userInfo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 70));

            start.Search(userInfo);
        }
    }
}
