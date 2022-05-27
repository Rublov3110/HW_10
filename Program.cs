using System;
using HW_10.Servis;

namespace HW_10
{
    public class Program
    {
        public static void Main()
        {
            Start start = new Start();
            start.Run();
            start.Сondition();
            Console.ReadKey();
        }
    }
}