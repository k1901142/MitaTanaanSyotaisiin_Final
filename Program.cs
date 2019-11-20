using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitaTanaanSyotaisiin
{
    class Program
    {
        static void Main(string[] args)
        {
            RaakaAine uusiRaakaAine = new RaakaAine();
            List<RaakaAine> raakaAineet = new List<RaakaAine>();
            char jatketaan;

            do
            {
                //uusiRaakaAine.SyotaUusiRaakaAine();
                //Console.WriteLine("Syötä uusi raaka-aine: ");
                //uusiRaakaAine.nimi = Console.Readline();
                uusiRaakaAine.nimi = uusiRaakaAine.SyotaUusiRaakaAine();


                //Console.WriteLine("Syötä " + uusiRaakaAine.Nimi + " energiasisältö (kcal): ");
                //uusiRaakaAine.Kalorit = Console.ReadLine();
                uusiRaakaAine.kalorit = uusiRaakaAine.SyotaEnergiaMaara();

                // + lisää tietoa raaka-aineesta

                raakaAineet.Add(uusiRaakaAine);

                Console.WriteLine("Syötätkö lisää K/E?");
                jatketaan = char.Parse(Console.ReadLine());
            } while (jatketaan == 'K' || jatketaan == 'k');

            foreach (RaakaAine raakaAine in raakaAineet) 
            {
                raakaAine.Listaa();
            }

            Console.ReadLine();



        }
    }
}
