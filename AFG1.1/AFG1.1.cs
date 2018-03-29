using System;

namespace AFG1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double v;


            var Num = (args[1]);
            double d = Convert.ToDouble(Num);

            switch (args[0])
            {
                case "w":
                    Console.WriteLine("Es werden die Daten für den Würfel berechnet!");
                    a = getCubeSurface(d);
                    v = getCubeVolume(d);
                    getCubeInfo(a, v);
                    break;
                case "k":
                    Console.WriteLine("Daten für die Kugel wierden berschnet");
                    a = getSphereSurface(d);
                    v = getSphereVolume(d);
                    getSphereInfo(a, v);
                    break;
                case "o":
                    Console.WriteLine("Es werden die Daten für den Octaeder berechnet");
                    a = getOcSurface(d);
                    v = getOcVolume(d);
                    getOcInfo(a, v);
                    break;
                default:
                    Console.WriteLine("Verstehe ich nicht");
                    break;
            }

        }
        //Methoden Würfel
        public static double getCubeSurface(double durchmesser)
        {
            double d = durchmesser;
            double a = Math.Round(6 * (d * d),2);
            return a;
        }
        public static double getCubeVolume(double durchmesser)
        {
            double d = durchmesser;
            double v = Math.Round((d * d * d),2);
            return v;
        }
        public static void getCubeInfo(double surface, double volume)
        {
            double a = surface;
            double v = volume;
            Console.WriteLine("A=" + a + " | " + "V=" + v);
        }

        //Methoden Kugel
        public static double getSphereSurface(double durchmesser)
        {
            double d = durchmesser;
            double a = Math.Round(Math.PI * (d * d),2);
            return a;
        }
        public static double getSphereVolume(double durchmesser)
        {
            double d = durchmesser;
            double v = Math.Round((Math.PI * (d * d * d)) / 6,2);
            return v;
        }
        public static void getSphereInfo(double surface, double volume)
        {
            double a = surface;
            double v = volume;
            Console.WriteLine("A=" + a + " | " + "V=" + v);
        }

        //Method Oktaeder
        public static double getOcSurface(double durchmesser)
        {
            double d = durchmesser;
            double a = Math.Round(2 * Math.Sqrt(3) * (d * d),2);
            return a;
        }
        public static double getOcVolume(double durchmesser)
        {
            double d = durchmesser;
            double v = Math.Round((Math.Sqrt(2) * (d * d * d)) / 3,2);
            return v;
        }
        public static void getOcInfo(double surface, double volume)
        {
            double a = surface;
            double v = volume;
            Console.WriteLine("A=" + a + " | " + "V=" + v);
        }
    }
}
