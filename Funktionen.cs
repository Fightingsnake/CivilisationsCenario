using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammKlassen
{
    internal class Funktionen
    {
        public static string VornameMann()
        {
            string[] verfuegbareNamen = { "Achim", "Adam", "Adolf", "Albert", "Albrecht", "Alexander", "Alfons", "Alfred", "Ali",
                              "Alois", "Andre", "Andreas", "Anton", "Antonio", "Armin", "Arno", "Arnold", "Arthur",
                              "Artur", "August", "Axel", "Benjamin", "Benno", "Bernd", "Bernhard", "Berthold", "Björn",
                              "Bodo", "Boris", "Bruno", "Burkhard", "Carsten", "Christi", "Christof", "Christoph",
                              "Claus", "Clemens", "Daniel", "David", "Dennis", "Detlef", "Detlev", "Dieter", "Dietmar",
                              "Dietrich", "Dirk", "Dominik", "Eberhard", "Eckhard", "Edgar", "Edmund", "Eduard",
                              "Edwin", "Egon", "Elmar", "Emil", "Engelbert", "Erhard", "Erich", "Ernst", "Erwin",
                              "Eugen", "Ewald", "Felix", "Ferdinand", "Florian", "Frank", "Franz", "Franz_Josef",
                              "Fred", "Friedhelm", "Friedrich", "Fritz", "Georg", "Gerald", "Gerd", "Gerhard", "Gernot",
                              "Gerold", "Gert", "Giuseppe", "Gottfried", "Gregor", "Guido", "Gunter", "Gustav", "Hans",
                              "Hans_Dieter", "Hans_Georg", "Hans_Joachim", "Hans_Jörg", "Hans_Jürgen", "Hans_Peter",
                              "Hans_Ulrich", "Hans_Wern", "Harald", "Harry", "Hartmut", "Heiko", "Heiner", "Heinrich",
                              "Heinz", "Heinz_Dieter", "Helmut", "Helmuth", "Henning", "Henry", "Herbert", "Heribert",
                              "Hermann", "Holger", "Horst", "Hubert", "Hubertus", "Hugo", "Ingo", "Jakob", "Jan",
                              "Jens", "Joachim", "Jochen", "Johann", "Johannes", "Josef", "Karl", "Karlheinz",
                              "Karsten", "Klaus", "Klaus_Dieter", "Klaus_Peter", "Knut", "Konrad", "Kurt", "Lars",
                              "Leo", "Leonhard", "Lorenz", "Lothar", "Ludger", "Ludwig", "Lutz", "Maik", "Manfred",
                              "Manuel", "Marc", "Marcel", "Marco", "Marcus", "Mario", "Mark", "Marko", "Markus",
                              "Martin", "Mathias", "Max", "Mehmet", "Michael", "Mike", "Mirko", "Mustafa", "Nikolaus",
                              "Norbert", "Olaf", "Oliver", "Oskar", "Oswald", "Ottmar", "Otto", "Patrick", "Paul",
                              "Peter", "Philipp", "Raimund", "Rainer", "Ralf", "Ralph", "Reiner", "Reinhard",
                              "Reinhold", "Rene", "Richard", "Robert", "Roland", "Rolf", "Roman", "Ronald", "Ronny",
                              "Rüdiger", "Rudolf", "Sebastian", "Sergej", "Siegfried", "Simon", "Stefan", "Steffen",
                              "Stephan", "Sven", "Theo", "Theodor", "Thomas", "Thorsten", "Tim", "Timo", "Tobias",
                              "Toni", "Torsten", "Udo", "Ulf", "Ulrich", "Uwe", "Viktor", "Vladimir", "Volker",
                              "Volkmar", "Waldemar", "Walter", "Werner", "Wilfried", "Wilhelm", "Willi", "Willibald",
                              "Willy", "Winfried", "Wolfgang", "Wolfram", "Xaver" };
            Random random = new Random();
            return verfuegbareNamen[random.Next(verfuegbareNamen.Length)];
        }
        public static string VornameFrau()
        {
            string[] verfuegbareNamen = {"Paula", "Magdalena", "Johanna", "Bettina", "Susanne", "Emilia", "Maria", "Birgit",
                              "Marianne", "Ute", "Ingrid", "Verena", "Marion", "Ramona", "Viola", "Klara", "Cornelia",
                              "Elisa", "Daniela", "Helena", "Tina", "Gertrud", "Alexandra", "Michaela", "Mia", "Annika",
                              "Franziska", "Anke", "Liselotte", "Romana", "Veronika", "Anna", "Edith", "Laura", "Hilde",
                              "Linda", "Dorothea", "Luise", "Lara", "Lisa", "Sandra", "Janine", "Theresa", "Heidi",
                              "Stefanie", "Dana", "Andrea", "Corinna", "Judith", "Silke", "Pauline", "Lena", "Astrid",
                              "Lea", "Anne", "Julia", "Bianka", "Bianka", "Elisabeth", "Rebecca", "Marlene", "Silke",
                              "Regina", "Isabell", "Evi", "Ina", "Helga", "Ines", "Saskia", "Inge", "Elke", "Monika",
                              "Sarah", "Martina", "Nicole", "Jasmin", "Doris", "Eva", "Sophia", "Christiane", "Antonia",
                              "Petra", "Amelie", "Nathalie", "Tanja", "Leonie", "Katharina", "Miriam", "Rita",
                              "Brigitte", "Christina", "Pia", "Annemarie", "Rosa", "Angela", "Hannelore", "Anneliese",
                              "Miriam", "Karolin", "Kathrin"};
            Random random = new Random();
            return verfuegbareNamen[random.Next(verfuegbareNamen.Length)];
        }
        public static string Nachname()
        {
            string[] verfuegbareNamen = {"Ackermann", "Adam", "Albrecht", "Arndt", "Arnold", "Bach", "Bachmann", "Barth", "Bartsch",
                          "Bauer", "Baumann", "Bayer", "Beck", "Becker", "Beckmann", "Behrens", "Bender", "Berg",
                          "Berger", "Bergmann", "Beyer", "Binder", "Bischoff", "Blum", "Bock", "Böhm", "Böhme",
                          "Böttcher", "Brand", "Brandt", "Braun", "Breuer", "Brinkman", "Brunner", "Bruns", "Buchholz",
                          "Busch", "Büttner", "Dietrich", "Dietz", "Döring", "Ebert", "Eckert", "Engel", "Engelhardt",
                          "Ernst", "Fiedler", "Fink", "Fischer", "Förster", "Frank", "Franke", "Franz", "Frey",
                          "Friedrich", "Fritz", "Fröhlich", "Fuchs", "Gärtner", "Geiger", "Gerlach", "Göbel",
                          "Götz", "Graf", "Grimm", "Grosz", "Gruber", "Günther", "Haas", "Haase", "Hahn", "Hansen",
                          "Hartmann", "Hein", "Heinrich", "Heinz", "Heller", "Hermann", "Herzog", "Hesse",
                          "Hildebrandt", "Hirsch", "Hoffmann", "Hofmann", "Hoppe", "Horn", "Huber", "Hübner", "Jäger",
                          "Jahn", "Jakob", "Jansen", "Janssen", "John", "Jung", "Kaiser", "Kaufmann", "Keller", "Kern",
                          "Kiefer", "Kirchner", "Klein", "Koch", "Kohl", "Köhler", "Kolb", "König", "Kopp", "Körner",
                          "Kraft", "Kramer", "Krämer", "Kraus", "Krause", "Krebs", "Krüger", "Kruse", "Kuhn", "Kühn",
                          "Kunz", "Kunze", "Kurz", "Lang", "Lange", "Langer", "Lehmann", "Lenz", "Lindner", "Link",
                          "Löffler", "Lorenz", "Ludwig", "Lutz", "Maier", "Martin", "Marx", "Maurer", "May", "Mayer",
                          "Meier", "Meiszner", "Menzel", "Meyer", "Michel", "Mohr", "Möller", "Moser", "Müller",
                          "Münch", "Nagel", "Naumann", "Neumann", "Nowak", "Ott", "Otto", "Paul", "Peter", "Peters",
                          "Petersen", "Pfeifer", "Pfeiffer", "Pohl", "Reichert", "Reimann", "Reinhard", "Renner",
                          "Reuter", "Richter", "Riedel", "Rieger", "Ritter", "Rose", "Roth", "Rudolph", "Sander",
                          "Sauer", "Schäfer", "Schenk", "Scherer", "Schiller", "Schillin", "Schindler", "Schlüter",
                          "Schmid", "Schmidt", "Schmitt", "Schmitz", "Schneider", "Scholz", "Schramm", "Schreibe",
                          "Schröder", "Schröter", "Schubert", "Schulte", "Schultz", "Schulz", "Schulze", "Schumacher",
                          "Schumann", "Schuster", "Schütz", "Schwab", "Schwarz", "Seidel", "Seifert", "Seitz", "Simon",
                          "Sommer", "Stahl", "Stark", "Stein", "Steiner", "Stephan", "Sturm", "Thiel", "Thiele",
                          "Thomas", "Ullrich", "Ulrich", "Unger", "Urban", "Vetter", "Vogel", "Vogt", "Voigt", "Vosz",
                          "Wagner", "Walter", "Walther", "Weber", "Wegner", "Weisz", "Wendt", "Wenzel", "Werner",
                          "Wilhelm", "Winkler", "Winter", "Wirth", "Witt", "Wittmann", "Wolf", "Wolff", "Wolter",
                          "Ziegler", "Zimmer", "Zimmerman"};
            Random random = new Random();
            return verfuegbareNamen[random.Next(verfuegbareNamen.Length)];
        }
        public static int StatistikenAbfrage()
        {
            Console.WriteLine("1 = lebendige Personen\n2 = tote Personen\n3 = aktuelles Datum\n4 = Geschlechter in Prozent\n5 = Alter in Prozent");
            Console.Write("Was möchtest du dir anschauen?: ");
            try
            {
                int eingabe = Convert.ToInt32(Console.ReadLine());
                return eingabe;
            }
            catch (Exception)
            {
                Console.WriteLine("Das war eine ungueltige Eingabe.");
            }
            return -1;
        }
        public static void ZeitspruengeAendern(int[] zeiten)
        {
            
            Console.WriteLine("1: Stunden\n2: Minuten\n3: Sekunden\n4: Tage\n5: Monate\n6: Jahre");
            Console.Write("Welche Zahl möchtest du bearbeiten? : ");
            int antwort = Convert.ToInt32(Console.ReadLine());           
            if (antwort >= 1 && antwort <= 6)
            {
                Console.WriteLine("Wie hoch soll der Wert sein? ");
                int neu = Convert.ToInt32(Console.ReadLine());
                zeiten[antwort-1] = neu;
            }
            else
                Console.WriteLine("Gib einen gueltigen Wert ein.");
        }
    }
}
