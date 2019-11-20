using System;

namespace MitaTanaanSyotaisiin
{

    /*Tämä luokka on kotitalouden varastojen kyselyyn ja tallentamiseen, siis yksinkertaiseen varastokirjanpitoon. Tämän avulla voidaan 
     * kysellä, mitä olemassa olevilla raaka-aineilla on mahdollista saada aikaiseksi. 
     */

    public class Class1
    {
        public Class1()
        {
        }

        // Luetaan tiedostosta viimeisin tilanne
        // Kysytään otetaanko vai laitetaanko kaappiin, mitä ja kuinka paljon
        // Jos ko. raaka-ainetta ei ole entuudestaan, hyödynnetään RaakaAine-luokkaa
        // Tallennetaan tiedostoon
        /* Kysytään, minkä tyyppistä ruokaa käyttäjä haluaa syödä -> ehdotetaan reseptiä ja tutkitaan kaappien sisältöä, löytyykö 
         * kaikki ainekset niin, että mahdollisimman moni aineksista löytyy kaapista. Jos ei, ilmoitetaan puuttuvat aineet, 
         * lisätään siis kauppalistalle. Jos käyttäjä päättää toteuttaa ehdotetun reseptin, ainekset vähennetään varastokirjanpidosta.
        // Toinen versio on, että ehdotetaan kaapissa olevien aineksien pohjalta jotakin reseptiä.
    }

}
