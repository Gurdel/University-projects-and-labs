using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongArifm
{
    class Program
    {
        static void Main(string[] args)
        {
            LongCalculator calc = new LongCalculator();
            
            Console.WriteLine(calc.factorPollard("8051"));
            Console.WriteLine(calc.factorPollard(calc.Mult("29", "16451")));
            Console.WriteLine(calc.factorPollard("17348256187264213649126346457"));
            Console.WriteLine(calc.factorPollard("13"));
            Console.WriteLine(calc.factorPollard("182579"));
            Console.WriteLine("@@@@@@ TEST END @@@@@");

            Console.WriteLine(calc.logBigSmal("3", "1", "17"));//16
            Console.WriteLine(calc.logBigSmal("3", "13", "17"));//4
            Console.WriteLine(calc.logBigSmal("2", "49", "101"));//18
            Console.WriteLine(calc.logBigSmal("3", "1", "17"));//16
            Console.WriteLine(calc.logBigSmal("3", "57", "113"));//100
            Console.WriteLine(calc.Pow("3", "24516822", "196134577"));
            Console.WriteLine(calc.Pow("3", "171617754", "196134577"));
            Console.WriteLine(calc.logBigSmal("3", "1", "196134577"));
            Console.WriteLine("@@@@@@ TEST END @@@@@");


            Console.WriteLine(calc.Mobius("1"));
            Console.WriteLine(calc.Mobius("2"));
            Console.WriteLine(calc.Mobius("13"));
            Console.WriteLine(calc.Mobius("2730"));
            Console.WriteLine(calc.Mobius("5460"));
            Console.WriteLine(calc.Mobius("10920"));
            Console.WriteLine("@@@@@@ TEST END @@@@@");

            for (int i = 1; i < 100; ++i)
            {
                Console.WriteLine(i + " " +calc.Euler(i.ToString()));

            }
            Console.WriteLine("@@@@@@ TEST END @@@@@");


            Console.WriteLine(calc.Jacobi("2", "15")); //1
            Console.WriteLine(calc.Jacobi("7", "15")); //-1
            Console.WriteLine(calc.Jacobi("7", "5")); //-1
            Console.WriteLine(calc.Jacobi("7", "3")); //1
            Console.WriteLine(calc.Jacobi("1001", "9907")); //-1
            Console.WriteLine(calc.Jacobi("219", "383")); //1
            Console.WriteLine(calc.Jacobi("10", "13")); //1
            Console.WriteLine(calc.Jacobi("1350", "1381")); //-1
            Console.WriteLine("@@@@@@ TEST END @@@@@");

            Console.WriteLine(calc.Chipolla("10", "13"));
            Console.WriteLine(calc.Chipolla("10", "13"));
            Console.WriteLine(calc.Chipolla("10", "13"));
            Console.WriteLine(calc.Chipolla("10", "13"));
            Console.WriteLine("@@@@@@ TEST END @@@@@");


            Console.WriteLine(calc.prost("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine(calc.SoloveyShtrassen("18446744082299486207"));
            Console.WriteLine("@@@@@@ TEST END @@@@@");

            Console.WriteLine(calc.prost("19") + " _ " + calc.SoloveyShtrassen("19"));
            Console.WriteLine(calc.prost("19") + " _ " + calc.SoloveyShtrassen("19"));
            Console.WriteLine(calc.prost("19") + " _ " + calc.SoloveyShtrassen("19"));
            Console.WriteLine(calc.prost("19") + " _ " + calc.SoloveyShtrassen("19"));
            Console.WriteLine();
            Console.WriteLine("@@@@@@ ________________TEST END ________________________--@@@@@");
            Console.ReadKey();

        }
    }
}
