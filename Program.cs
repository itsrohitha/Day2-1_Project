using System;

namespace Day2_1_Project
    /*if number of leave is greater than 7 then no
     * if less then yes
     * */
{
    class Program
    {
        static void Main(string[] args)
        {
         try
            {
                Console.WriteLine("How many days of leave do you want?");
                int leave = int.Parse(Console.ReadLine());

                if(leave > 7)
                {
                    Console.WriteLine("You can not request for leave");
                }
                else
                {
                    Console.WriteLine("You may request for leave");
                }
            }
        catch
            {
                Console.WriteLine("you have an error");
            }
        }
    }
}
