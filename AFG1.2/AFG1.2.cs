using System;

namespace AFG1._2
{
    class Program
    {
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };
        static string Subject;
        static string Verb;
        static string Object;
        static void Main(string[] args)
        {
            string[] verse = new string[subjects.Length];
            for (int i = 0; i < subjects.Length; i++)
            {
                GetVerse();
                verse[i] = Subject + " " + Verb + " " + Object;
            }
            for (int j = 0; j < subjects.Length; j++)
            {
                Console.WriteLine(verse[j]);
            }
        }
        public static void GetVerse()
        {
            Random random = new Random();
            int a = random.Next(0, subjects.Length);
            int b = random.Next(0, verbs.Length);
            int c = random.Next(0, objects.Length);
            
            while (subjects[a] == "used")
            {
                a = random.Next(0, subjects.Length);
            }
            while (verbs[b] == "used")
            {
                b = random.Next(0, verbs.Length);
            }
            while (objects[c] == "used")
            {
                c = random.Next(0, objects.Length);
            }
            Subject = subjects[a];
            Verb = verbs[b];
            Object = objects[c];

            subjects[a] = "used";
            verbs[b] = "used";
            objects[c] = "used";
        }
    }
}
