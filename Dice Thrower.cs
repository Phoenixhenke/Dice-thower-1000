using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)");
            ThrowDice("10d6");
            Console.WriteLine("2)");
            ThrowDice("3d20");
            Console.WriteLine("3)");
            ThrowDice("100d6");




            Console.ReadKey();
        }
        static void ThrowDice(string dicestring)
        {
            List<string> dicestringlist = dicestring.Split('d').ToList();// to 0
            int n = int.Parse(dicestringlist[0]);//two only varibles.
            int m = int.Parse(dicestringlist[1]);
            Random randomNumbergenerator = new Random();
            for (int i = 1; i <= n; i++)
            {// to make random numbers depending on the varible of m.
                int randomNumber = randomNumbergenerator.Next(1, m + 1);
                Console.Write(randomNumber);
            }
        }
    }
}
