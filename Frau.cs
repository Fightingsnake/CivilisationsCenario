using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammKlassen
{
    internal class Frau : Person
    {
        protected static int _CountFrauen;
        private bool _IsSchwanger { get; set; }

        internal override string _Gender { get; set; }
        internal override string _Name { get; set; }
        // ===== [ Konstruktoren ] =====
        public Frau(int[] Datum)
        {
            this.SetBirthday(Datum);
            Gender = "Frau";
            Name = $"{Funktionen.VornameFrau()} {Funktionen.Nachname()}";
            _CountFrauen++;
        }
        // ===== [ GetterSetter ] =====
        public static int CountFrauen
        {
            get
            { return _CountFrauen; }
        }

        // ===== [ Methoden ] =====

        public int Schwangerschaft()
        {
            Random random = new Random();
            if (this.Age > 15 && this.Age < 20)
            {
                if (random.Next(101) < 24)
                {
                    _IsSchwanger = true;
                    return 1;
                }
                else
                    return 0;
            }
            else if (this.Age >= 20 && this.Age < 35)
            {
                if (random.Next(101) < 40)
                {
                    _IsSchwanger = true;
                    return 1;
                }
                else
                    return 0;
            }
            else if (this.Age >= 35 && this.Age < 50)
            {
                if (random.Next(101) < 30)
                {
                    _IsSchwanger = true;
                    return 1;
                }
                else
                    return 0;
            }
            else if (this.Age >= 50 && this.Age < 70)
            {
                if (random.Next(101) < 7)
                {
                    _IsSchwanger = true;
                    return 1;
                }
                else
                    return 0;
            }
            else
                return -1;
        }
        //public int Geburt()
        //{

        //}
    }
}
