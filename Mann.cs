using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammKlassen
{
    internal class Mann : Person
    {
        protected static int _CountMaenner;
        internal override string _Gender { get; set; }
        internal override string _Name { get; set; }
        internal bool _IsPotent;

        // ===== [ Konstruktoren ] =====
        public Mann(int[] Datum)
        {
            this.SetBirthday(Datum);
            Gender = "Mann";
            Name = $"{Funktionen.VornameMann()} {Funktionen.Nachname()}";
            _CountMaenner++;
        }
        // ===== [ GetterSetter ] =====
        public static int CountMaenner
        {
            get
            { return _CountMaenner; }
        }
        public bool IsPotent
        {
            get { return _IsPotent; }
            set { _IsPotent = value; }
        }
        // ===== [ Methoden ] =====



    }
}
