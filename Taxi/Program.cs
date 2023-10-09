using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();
            string[] olvasottSorok = File.ReadAllLines("data\\fuvar.csv");

            for (int i = 1; i < olvasottSorok.Length; i++)
            {
                string[] tagok = olvasottSorok[i].Split(';');
                Fuvar ujFuvar = new Fuvar(int.Parse(tagok[0]), tagok[1], int.Parse(tagok[2]), double.Parse(tagok[3]), double.Parse(tagok[4]), double.Parse(tagok[5]), tagok[6]);
                fuvarok.Add(ujFuvar);
            }
            //3. Feladat:
            Console.WriteLine($"3. feladat: {fuvarok.Count()} fuvar");

            //4. Feladat:
            int fuvarok_szama = 0;
            double ossz_bevetel = 0;

            foreach (var fuvar in fuvarok)
            {
                if (fuvar.Azonosito == 6185)
                {
                    fuvarok_szama++;
                    ossz_bevetel += fuvar.Viteldij + fuvar.Borravalo;
                }
            }
            Console.WriteLine($"4. feladat: {fuvarok_szama} fuvar alatt: {ossz_bevetel}$");

            //5. Feladat:
            int bankkartyas = 0;
            int keszpenzes = 0;
            int vitatott = 0;
            int ingyenes = 0;
            int ismeretlen = 0;
            Console.WriteLine("5.feladat:");
            foreach (var fuvar in fuvarok)
            {
                if (fuvar.Fizetes_modja == "bankkártya")
                {
                    bankkartyas++;
                }
                else if (fuvar.Fizetes_modja == "készpénz")
                {
                    keszpenzes++;
                }
                else if (fuvar.Fizetes_modja == "vitatott")
                {
                    vitatott++;
                }
                else if (fuvar.Fizetes_modja == "ingyenes")
                {
                    ingyenes++;
                }
                else
                {
                    ismeretlen++;
                }
            }

            Console.WriteLine($"\t bankkártya: {bankkartyas} fuvar");
            Console.WriteLine($"\t készpénz: {keszpenzes} fuvar");
            Console.WriteLine($"\t vitatott: {vitatott} fuvar");
            Console.WriteLine($"\t ingyenes: {ingyenes} fuvar");
            Console.WriteLine($"\t ismeretlen: {ismeretlen} fuvar");

        }
    }
}