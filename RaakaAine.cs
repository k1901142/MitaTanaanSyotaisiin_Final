using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Tässä luokassa kysellään raaka-aineiden nimet ja kalorimäärät. Muutakin tietoa voidaan lisätä haluttaessa.*/

namespace MitaTanaanSyotaisiin
{
    public class RaakaAine
    {
        public string nimi = "";
        public string kalorit = "";

        // Lue tiedostosta valmiina olevat raaka-aineet
        
        // Tutkitaan, onko haluttu raaka-aine jo listalla

        // Jos raaka-aine ei ole jo valmiina listalla, syötetään uusi
        public string SyotaUusiRaakaAine()
        { 
            Console.WriteLine("Syötä uusi raaka-aine: ");
            nimi = Console.ReadLine();

            return nimi;

            //uusiRaakaAine.Nimi = Console.ReadLine();

        }

        // Tämä yhdistetään SyotaUusiRaakaAine-metodiin.
        public string SyotaEnergiaMaara()
        {
            Console.WriteLine("Syötä energiasisältö (kcal): ");
            kalorit = Console.ReadLine();

            return kalorit;

            //uusiRaakaAine.Kalorit = Console.ReadLine();
        }

        // Järjestetään raaka-aineet aakkosjärjestykseen

        public void Listaa()
        {
            Console.WriteLine("Raaka-aine: {0}, Kalorit: {1}", nimi, kalorit);
        }

        // Tallenna tiedostoon

        /*
         * private string mitaAutoSanoo = "";

        public string rekNro = ""; // näin alustaessa ei tule ongelmia Null-arvon kanssa, olio voi kapseloida tietoa jonnekin

        public void MitaSanoo(string teksti)
        {
            mitaAutoSanoo = teksti;
        }

        public void Aja()
        {
            Console.WriteLine(mitaAutoSanoo);
        }
         */
    }
}
