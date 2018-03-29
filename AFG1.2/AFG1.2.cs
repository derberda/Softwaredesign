using System;

namespace AFG1._2
{
    class Program
    {
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };
        static string s;
        static string v;
        static string o;
        static void Main(string[] args)
        {
            string[] str = new string[subjects.Length];
            for (int i = 0; i < subjects.Length; i++)
            {
                GetVerse();
                str[i] = s + " " + v + " " + o;
            }
            for (int j = 0; j < subjects.Length; j++)
            {
                Console.WriteLine(str[j]);
            }
        }
        public static void GetVerse()
        {
            // Console.WriteLine(" ");
            // for (int i = 0; i < subjects.Length; i++)
            // {
            Random random = new Random();
            int a = random.Next(0, subjects.Length);
            int b = random.Next(0, verbs.Length);
            int c = random.Next(0, objects.Length);
            //Console.WriteLine(subjects[a] + " " + verbs[b] + " " + objects[c]);
            // }
            while (subjects[a] == "benutzt")
            {
                a = random.Next(0, subjects.Length);
            }
            while (verbs[b] == "benutzt")
            {
                b = random.Next(0, verbs.Length);
            }
            while (objects[c] == "benutzt")
            {
                c = random.Next(0, objects.Length);
            }
            s = subjects[a];
            v = verbs[b];
            o = objects[c];

            subjects[a] = "benutzt";
            verbs[b] = "benutzt";
            objects[c] = "benutzt";
        }
    }
}
