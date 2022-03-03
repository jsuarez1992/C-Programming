using System;

namespace Exercise002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LotteryRow row = new LotteryRow();
            Console.WriteLine("Lottery numbers:");
            foreach (int number in row.numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}