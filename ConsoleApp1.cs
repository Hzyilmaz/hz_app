using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double kWh, aw, g1, g2, k1, k2;
            string name, pw;

            Console.WriteLine("Stromkostenvergleich");
            Console.WriteLine();
            Console.Write("Bitte geben Sie Ihren Benutzernamen ein: ");
            name = Console.ReadLine();
            Console.Write("Bitte geben Sie Ihr Kennwort ein: ");
            pw = Console.ReadLine();
            if (name == "Jens" && pw == "Hlawitschka")
            {
                Console.WriteLine("Hallo " + name + "!");
                Console.Write("Bitte geben Sie den Preis in Euro je kWh ein: ");
                kWh = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wollen Sie einen Vergleich zwischen");
                Console.WriteLine("1.Laptop und Desktop oder");
                Console.WriteLine("2.LED-Leuchte und Energiesparleuchte durchführen?");
                Console.Write("Bitte geben Sie Ihre Auswahl ein: ");
                aw = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Leistungsaufnahme Gerät 1 in Watt: ");
                g1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Leistungsaufnahme Gerät 2 in Watt: ");
                g2 = Convert.ToDouble(Console.ReadLine());

                k1 = g1 / 1000 * kWh * 5 * 365 * 3;             //Alle Geräte werden 5 Stunden pro Tag verwendet für 3 Jahre
                k2 = g2 / 1000 * kWh * 5 * 365 * 3;

                Console.WriteLine("Energiekosten für drei Jahre");
                Console.WriteLine("                     ");

                if (aw == 1)
                {
                    Console.WriteLine("Laptop: {0} Euro", k1);
                    Console.WriteLine("normaler PC: {0} Euro", k2);
                }
                if (aw == 2)
                {
                    Console.WriteLine("LED-Leuchte: {0} Euro", k1);
                    Console.WriteLine("Energiesparleuchte: {0} Euro", k2);
                }
                if (aw < 1 || aw > 2)
                {
                    Console.WriteLine("Gerät 1 : {0} Euro", k1);
                    Console.WriteLine("Gerät 2: {0} Euro", k2);
                }
            }
            else
            {
                Console.WriteLine("Programmende wegen falscher Anmeldedaten.");
            }
            Console.ReadLine();
            }
        }
    }
