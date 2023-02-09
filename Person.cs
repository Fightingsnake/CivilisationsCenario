using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammKlassen
{
    internal abstract class Person
    {
        private static int _CountPerson;

        // ===== [ Eigenschaftsmethoden ] =====
        internal int _Age;
        internal abstract string _Gender { get; set; }
        internal abstract string _Name { get; set; }
        internal bool _Married;
        internal string _Partner;
        internal int _BirthDay;
        internal int _BirthMonth;
        internal int _BirthYear;
        internal bool alive { get; set; }

        // ===== [ Konstruktoren ] =====
        protected Person()
        {
            _CountPerson++;
        }

        // ===== [ GetterSetter ] =====
        public static int CountPerson
        {
            get { return _CountPerson; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public bool Married
        {
            get { return _Married; }
            set { _Married = value; }
        }
        public string Partner
        {
            get { return _Partner; }
            set { _Partner = value; }
        }
        public int BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }
        public int BirthMonth
        {
            get { return _BirthMonth; }
            set { _BirthMonth = value; }
        }
        public int BirthYear
        {
            get { return _BirthYear; }
            set { _BirthYear = value; }
        }
        // ===== [ Methoden ] =====

        protected void SetBirthday(int[] Geburtstag)
        {
            this.BirthDay = Geburtstag[0];
            this.BirthMonth = Geburtstag[1];
            this.BirthYear = Geburtstag[2];
        }
        public void Geburtstag()
        {
            Console.WriteLine($"{this.Name} hat Geburtstag.");
            Random random = new Random();
            if (random.Next(101) < 89)
                Console.WriteLine("Der Geburtstag verlief ruhig...");
            else
                Console.WriteLine("Es war eine wilde Party.");
        }
    }
}
