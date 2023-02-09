using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace TestProgrammKlassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== [ Allgemeine Initialisierungen ] =====
            Console.Title = "Zivilerie";
            Kalender kalenderDortmund = new Kalender();
            Gesellschaft Dortmund = new Gesellschaft(kalenderDortmund);

            // ===== [ Allgemeiner Ablauf ] =====
            Dortmund.PersonenHinzufuegen(Settings.StartFrauen, 'F');
            Dortmund.PersonenHinzufuegen(Settings.StartMaenner, 'M');
            
            do
            {
                Console.WriteLine("Tippe 'w' zum fortfuehren\n's' fuer Statistiken\n'o' fuer Optionen\n'q' zum beenden");
                Console.Write("Was möchtest du tun?: ");
                try
                {
                    char eingabe = Convert.ToChar(Console.ReadLine());
                    if (eingabe == 'q')
                    {
                        Console.WriteLine("Das Programm wird beendet...");
                        Thread.Sleep(3639);
                        break;
                    }
                    else if (eingabe == 'w')
                        kalenderDortmund.Fortschreiten(Settings.Zeitspruenge, Dortmund);
                    else if (eingabe == 'o')
                    {
                        Console.WriteLine("1: Zeitspruenge");
                        Console.Write("Was moechtest du aendern? ");
                        int antwort = Convert.ToInt32(Console.ReadLine());
                        if (antwort == 1)
                            Funktionen.ZeitspruengeAendern(Settings.Zeitspruenge);
                    }
                    else if (eingabe == 's')
                    {
                        int antwort = Funktionen.StatistikenAbfrage();
                        if (antwort == 1)
                            Statistiken.MenschenZaehlen(Dortmund.LebendePersonen);
                        else if (antwort == 2)
                            Statistiken.MenschenZaehlen(Dortmund.TotePersonen);
                        else if (antwort == 3)
                            Statistiken.AusgabeDatum(Dortmund.GesellschaftsKalender.Today());
                        else if (antwort == 4)
                            Statistiken.GeschlechterVerteilung(Dortmund.LebendePersonen);
                        else if (antwort == 5)
                            Statistiken.AltersVerteilung(Dortmund.LebendePersonen);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Das war eine falsche Eingabe. (Ungueltiges oder zu viele Zeichen)");
                }
            } while (true);   
        }
    }
}
