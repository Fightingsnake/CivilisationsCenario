using System;
using System.Collections.Generic;
using System.Threading;

namespace TestProgrammKlassen
{
    internal class Gesellschaft
    {
        private List<object> _LebendePersonen = new List<object>();
        private List<object> _TotePersonen = new List<object>();
        private Kalender _GesellschaftsKalender;

        // ===== [ Konstruktoren ] =====
        public Gesellschaft() { }
        public Gesellschaft(Kalender kalender)
        {
            this.GesellschaftsKalender = kalender;
        }

        // ===== [ GetterSetter ] =====
        public List<object> LebendePersonen
        {
            get { return _LebendePersonen; }
            set { _LebendePersonen.Add(value); }
        }
        public List<object> TotePersonen
        {
            get { return _TotePersonen;}
            set { _TotePersonen.Add(value); }
        }
        public Kalender GesellschaftsKalender
        {
            get { return _GesellschaftsKalender; }
            set { _GesellschaftsKalender = value; }
        }

        // ===== [ Methoden ] =====
        public void PersonenHinzufuegen(int Anzahl, char Geschlecht)
        {
            for (int i = 0; i < Anzahl; i++)
            {
                Random random = new Random();
                Thread.Sleep(5);
                if (Geschlecht == 'M')
                {
                    Mann x = new Mann(GesellschaftsKalender.Today());
                    this.LebendePersonen.Add(x);
                }
                else if (Geschlecht == 'F')
                {
                    Frau x = new Frau(GesellschaftsKalender.Today());
                    this.LebendePersonen.Add(x);
                }
            }
        }
        //public Person Partnersuche(Person Frau, Person Mann)
        //{

        //}
    }
}
