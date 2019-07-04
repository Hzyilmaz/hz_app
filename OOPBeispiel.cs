using System;

namespace OOP_Beispiel
{
    class CRennwagen
    {
        private string name;
        private string farbe;
        private double kW;
        private double hubraum;
        private double preis;

        public void setzName(string n)
        {
            name = n;
        }
        public void setzFarbe(string f)
        {
            farbe = f;
        }
        public void setzkW(double k)
        {
            kW = k;
        }
        public void setzHubraum(double h)
        {
            hubraum = h;
        }
        public void setzPreis(double p)
        {
            preis = p;
        }

        public void AusgabeName()
        {
            Console.WriteLine("Name: {0}", name);
        }
        public void AusgabeFarbe()
        {
            Console.WriteLine("Farbe: {0}", farbe);
        }
        public void AusgabekW()
        {
            Console.WriteLine("Ausgabe: {0}", kW);
        }
        public void AusgabeHubraum()
        {
            Console.WriteLine("Hubraum: {0}", hubraum);
        }
        public void AusgabePreis()
        {
            Console.WriteLine("Preis: {0}", preis);
        }
        public void Tuning()
        {
            kW = kW + 77;
            preis = preis + 22222;
        }
        public void Unfall()
        {
            kW = kW * 0.1;
            preis = preis + 0.22;
        }
        public void Reparatur()
        {
            kW = kW * 10;
            preis = preis * 4;
        }
        public void Lackieren()
        {
            Console.WriteLine("Bitte Farbe eingeben: ");
            farbe = Console.ReadLine();
        }
    }

    class Programm
    { 
        static void Main(string[] args)
        {
            string aw;

            CRennwagen wagen1 = new CRennwagen();
            CRennwagen wagen2 = new CRennwagen();

            wagen1.setzName("Ferrari F1");
            wagen1.setzFarbe("rot");
            wagen1.setzkW(250);
            wagen1.setzHubraum(4.5);
            wagen1.setzPreis(250000);

            wagen2.setzName("Porsche 911");
            wagen2.setzFarbe("schwarz");
            wagen2.setzkW(300);
            wagen2.setzHubraum(5.5);
            wagen2.setzPreis(180000);

            do
            {
                Console.Clear();
                Console.WriteLine("Rennwagen-Simulation\n");
                Console.WriteLine("Menü\n");
                Console.WriteLine("Wagen 1                     Wagen 2");
                Console.WriteLine("11.Anzeigen                 21.Anzeigen                    ");
                Console.WriteLine("12.Tuning                   22.Tuning");
                Console.WriteLine("13.Unfall                   23.Unfall");
                Console.WriteLine("14.Reparatur                24.Reparatur             ");
                Console.WriteLine("15.Lackieren                25.Lackieren             ");
                Console.WriteLine("e.Ende\n");
                Console.Write("Bitte geben Sie Ihre Auswahl ein: ");
                aw = Console.ReadLine();
                Console.WriteLine();
                if (aw == "11")
                {
                    wagen1.AusgabeName();
                    wagen1.AusgabeFarbe();
                    wagen1.AusgabekW();
                    wagen1.AusgabeHubraum();
                    wagen1.AusgabePreis();
                }
                if (aw == "12")
                {
                    wagen1.Tuning();
                    Console.WriteLine("\nTuning bei Wagen1 durchgeführt!");
                }
                if (aw == "13")
                {
                    wagen1.Unfall();
                    Console.WriteLine("\nUnfallsimulation bei Wagen1 durchgeführt!");
                }
                if (aw == "14")
                {
                    Console.WriteLine("\nReparatur bei Wagen1 durchgeführt!:");
                    wagen1.Reparatur();
                }
                if (aw == "15")
                {
                    wagen1.Lackieren();
                    Console.WriteLine("\nLackierung bei wagen1 durchgeführt!:");
                }
                if (aw == "21")
                {
                    wagen2.AusgabeName();
                    wagen2.AusgabeFarbe();
                    wagen2.AusgabekW();
                    wagen2.AusgabeHubraum();
                    wagen2.AusgabePreis();
                }
                if (aw == "22")
                {
                    wagen2.Tuning();
                    Console.WriteLine("\nTuning bei Wagen2 durchgeführt");
                }
                if (aw == "23")
                {
                    wagen2.Unfall();
                    Console.WriteLine("\nUnfallsimulation bei Wagen2 durchgeführt1");
                }
                if (aw == "24")
                {
                    Console.WriteLine("\nReparatur bei Wagen2 durchgeführt!");
                    wagen2.Reparatur();
                }
                if (aw == "25")
                {
                    wagen2.Lackieren();
                    Console.WriteLine("\nLackierung bei wagen2 durchgeführt!:");
                }
                if (aw != "e")
                {
                    Console.WriteLine("\nWeiter geht es mit der Enter-Taste");
                    Console.ReadLine();
                }
            } while (aw != "e");
        }
    }
}
