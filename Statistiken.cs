using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammKlassen
{
    internal class Statistiken
    {
        /*
        Funktionen werden benoetigt, zur Ausgabe von:
        toten / lebenden personen
        altersstatistik %
        geschlechter verteilung %
        akt Datum & laufzeit oder aehnliches

        */
        public static void AusgabePersonen(List<object> verzeichnis)
        {
            foreach (Person person in verzeichnis)
            {
                Console.WriteLine(person.Name);
            }
        }
        public static void AusgabeDatum(int[] Datum)
        {
            string ausgabe = $"{Datum[0],2}.{Datum[1],2}.{Datum[2],4}";
            Console.WriteLine(ausgabe);
        }
        public static void GeschlechterVerteilung (List<object> verzeichnis)
        {
            int maennlich = 0, weiblich = 0;
            foreach (Person person in verzeichnis)
            {
                if (person.Gender == "Frau")
                    weiblich++;
                else
                    maennlich++;
            }
            Console.WriteLine($"Es leben zur Zeit {maennlich} Männer und {weiblich} Frauen in der Stadt.");
        }
        public static void MenschenZaehlen(List<object> verzeichnis)
        {
            int zaehler = 0;
            foreach (Person person in verzeichnis)
            {
                zaehler++;
            }
            Console.WriteLine($"Es sind {zaehler} Personen.");
        }
        public static void AltersVerteilung (List<object> verzeichnis)
        {
            int A0_4 = 0, A5_9 = 0, A10_17 = 0, A18_29 = 0, A30_45 = 0, A46_65 = 0, A66_80 = 0, A81_105 = 0;
            foreach (Person person in verzeichnis)
            {
                if (person.Age >= 0 && person.Age <= 4)
                    A0_4++;
                else if (person.Age >= 5 && person.Age <= 9)
                    A5_9++;
                else if (person.Age >= 10 && person.Age <= 17)
                    A10_17++;
                else if (person.Age >= 18 && person.Age <= 29)
                    A18_29++;
                else if (person.Age >= 30 && person.Age <= 45)
                    A30_45++;
                else if (person.Age >= 46 && person.Age <= 65)
                    A46_65++;
                else if (person.Age >= 66 && person.Age <= 80)
                    A66_80++;
                else if (person.Age >= 81 && person.Age <= 105)
                    A81_105++;
            }
            Console.WriteLine($"Im Alter zwischen  0 - 4 leben:   {Convert.ToString(A0_4).PadLeft(3, '0')}");
            Console.WriteLine($"Im Alter zwischen  5 - 9 leben:   {Convert.ToString(A5_9).PadLeft(3,'0')}");
            Console.WriteLine($"Im Alter zwischen 10 - 17 leben:  {Convert.ToString(A10_17).PadLeft(3, '0')}");
            Console.WriteLine($"Im Alter zwischen 18 - 29 leben:  {Convert.ToString(A18_29).PadLeft(3, '0')}");
            Console.WriteLine($"Im Alter zwischen 30 - 45 leben:  {Convert.ToString(A30_45).PadLeft(3, '0')}");
            Console.WriteLine($"Im Alter zwischen 46 - 65 leben:  {Convert.ToString(A46_65).PadLeft(3, '0')}");
            Console.WriteLine($"Im Alter zwischen 66 - 80 leben:  {Convert.ToString(A66_80).PadLeft(3, '0')}");
            Console.WriteLine($"Im Alter zwischen 81 - 105 leben: {Convert.ToString(A81_105).PadLeft(3, '0')}");
        }
    }
}
