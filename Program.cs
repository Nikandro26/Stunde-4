using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Der Benutzer soll nach einer Jahreszahl gefragt werden und es 
            //soll ausgegeben werden ob es sich um ein Schaltjahr handelt
            //Schaltjahr:teilbar durch 4; nicht teilbar durch 100; teilbar durch 400


            int jahr;
            Console.WriteLine("Eine Jahreszahl soll auf durch Schaltjahr überprüft werden");
            Console.Write("Jahreszahl eingeben");
            string wiederholung = "j";


            jahr = Convert.ToInt32(Console.ReadLine());

            if (jahr % 4 == 0 && (jahr % 100 != 0 || jahr % 400 == 0))
            {
                Console.WriteLine(jahr + "ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine(jahr + "ist kein Schaltjahr");
            }

            //do
            //{
            //    Console.WriteLine("Eine Jahreszahl soll auf Schaltjahr überprüft werden.");
            //    Console.Write("Jahreszahl eingeben");

            //    jahr = Convert.ToInt32(Console.ReadLine());

            //    if (jahr % 4 == 0)
            //    {
            //        if (jahr % 100 == 0)
            //        {
            //            if (jahr % 400 == 0)
            //            {
            //                Console.WriteLine(jahr + "Ist ein Schaltjahr.");
            //            }
            //            else
            //            {
            //                Console.WriteLine(jahr + "ist kein Schaltjahr.");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine(jahr + "ist ein Schaltjahr.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(jahr + "ist kein Schutjahr");
            //    }
            //Console.Write("Nochmal? (j/n):");
            //wiederholung = Console.ReadLine();

            //} while (wiederholung == "j" || wiederholung == "J"); 

            // oder : ||; und: &&

        }
    }
}
