using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.ComponentModel;

namespace TestProgrammKlassen
{
    internal class Kalender
    {
        protected int _Year = 1900;
        protected int _Month = 1;
        protected int _Day = 1;
        protected int _Hour = 0;
        protected int _Minute = 0;
        protected int _Second = 0;

        // ===== [ GetterSetter ] =====
        public int Year
        {
            get { return _Year; }
            set
            {
                _Year = value;
            }
        }
        public int Month
        {
            get { return _Month; }
            set
            {
                _Month = value;
                if (_Month > 12)
                {
                    _Month -= 12;
                    Year++;
                }
            }
        }
        public int Day
        {
            get { return _Day; }
            set
            {
                _Day = value;

                if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                {
                    if (_Day > 31)
                    {
                        Day -= 31;
                        Month++;
                    }
                }
                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    if (_Day > 30)
                    {
                        Day -= 30;
                        Month++;
                    }
                }
                else if (Month == 2 && Year % 4 == 0)
                {
                    if (_Day > 29)
                    {
                        Day -= 29;
                        Month++;
                    }
                }
                else if (Month == 2 && Year % 4 != 0)
                {
                    if (Day > 28)
                    {
                        Day -= 28;
                        Month++;
                    }
                }
            }
        }
        public int Hour
        {
            get { return _Hour; }
            set
            {
                _Hour = value;
                while (_Hour >= 24)
                {
                    _Hour -= 24;
                    Day++;
                }
            }
        }
        public int Minute
        {
            get { return _Minute; }
            set
            {
                _Minute = value;
                if (_Minute >= 60)
                {
                    _Minute -= 60;
                    Hour++;
                }
            }
        }
        public int Second
        {
            get { return _Second; }
            set
            {
                _Second = value;
                if (_Second >= 60)
                {
                    _Second -= 60;
                    Minute++;
                }
            }
        }

        // ===== [ Methoden ] =====
        public void Fortschreiten(int[] zeitspruenge, Gesellschaft gesello) // hour mins secs days mons year
        {
            this.Hour += zeitspruenge[0];
            this.Minute += zeitspruenge[1];
            this.Second += zeitspruenge[2];
            for (int i = 0; i < zeitspruenge[3]; i++)
            {
                this.TagVorwaerts(gesello);
            }
            for (int i = 0; i < zeitspruenge[4]; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    this.TagVorwaerts(gesello);
                };
            }
            for (int i = 0; i < zeitspruenge[5]; i++)
            {
                for (int j = 0; j < 365; j++)
                {
                    this.TagVorwaerts(gesello);
                }
            }
        }
        public void TagVorwaerts(Gesellschaft gesellschaft)
        {
            this.Day++;
            foreach (Person person in gesellschaft.LebendePersonen)
            {
                if (person.BirthMonth == this.Month)
                {
                    if (person.BirthDay == this.Day)
                    {
                        person.Geburtstag();
                    }
                }
            }
        }
        public int[] Today()
        {
            int[] datum = new int[] { this.Day, this.Month, this.Year };
            return datum;
        }
        public int[] Now()
        {
            int[] zeit = new int[] { this.Hour, this.Minute, this.Second };
            return zeit;
        }
        internal int[] DatumBerechnen(int[] draufRechnen)
        {
            int[] heute = Today();
            this.Day += draufRechnen[0];
            this.Month += draufRechnen[1];
            this.Year += draufRechnen[2];
            int[] ausgeben = new int[] { this.Day, this.Month, this.Year };
            this.Day = heute[0];
            this.Month = heute[1];
            this.Year = heute[2];
            return ausgeben;
        }
        public int[] Geburtstermin()
        {
            Random random = new Random();
            int TageSchwangerschaft = (7 * 4 * 9) + random.Next(-11, 12);
            int[] drauf = new int[] { TageSchwangerschaft, 0, 0 };
            int[] termin = DatumBerechnen(drauf);
            return termin;
        }

    }
}
