namespace Schulweg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true) 
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Mit welchem Transportmittel wollen sie zur Schule fahren? [Töff/Auto/Elektrovelo]");
                    String Fahrzeug = Console.ReadLine();
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.Write("Wie viele Kilometer ist ihr Schulweg? ");
                    double wegLänge = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    switch (Fahrzeug)
                    {
                        case "Töff":
                        case "töff":
                            Console.Write("Wie teuer ist ihr Töff? ");
                            double Preis = Convert.ToDouble(Console.ReadLine());
                            double kaufpreis = Preis / (10 * 378 * wegLänge);
                            double benzinPreis = 1.94 / 25;
                            double untersuchungsKosten = 150 / (378 * wegLänge);
                            double autoBahn = 40 / (378 * wegLänge);
                            double ölWechsel = 60 / (378 * wegLänge);
                            double gesamtkosten = kaufpreis + benzinPreis + untersuchungsKosten + autoBahn + ölWechsel;
                            Console.WriteLine("Mit dem Töff müssen sie per Kilometer {0} Franken bezahlen", gesamtkosten);
                            break;
                        case "Auto":
                        case "auto":
                            Console.Write("Wie viel kostet das Auto? ");
                            double autoPreis = Convert.ToDouble(Console.ReadLine());
                            double preisAuto = autoPreis / (15 * 378 * wegLänge);
                            double nummerSchild = 100 / (15 * 378 * wegLänge);
                            double benzinpreis = 1.94 / 17.3;
                            double versicherung = 3500 / (15 * 378 * wegLänge);
                            double steuer = 300 / (15 * 378 * wegLänge);
                            double autobahn = 40 / (378 * wegLänge);
                            double reparatur = 800 / 10000;
                            double Gesamtkostenauto = preisAuto + nummerSchild + benzinpreis + versicherung + steuer + autobahn + reparatur;
                            Console.WriteLine("Mit dem Auto müssen sie per Kilometer {0} Franken bezahlen.", Gesamtkostenauto);
                            break;
                        case "Evelo":
                        case "evelo":
                        case "ElektroVelo":
                        case "Elektrovelo":
                        case "elektrovelo":
                        case "elektroVelo":
                            Console.Write("Wie viel kostet ihr ElektroVelo? ");
                            double kosten = Convert.ToDouble(Console.ReadLine());
                            double längePreis = 0.3 * wegLänge;
                            double wartungKosten = 100 / (wegLänge * 378);
                            double Akku = 1000 / 60000;
                            double kaufPreis = kosten / (10 * 378 * wegLänge);
                            double gesamtKosten = längePreis + wartungKosten + Akku + kaufPreis;
                            Console.WriteLine("Das ElektroVelo wird sie per Kilometer {0} Franken kosten.", gesamtKosten);
                            break;
                        default:
                            throw new Exception();
                            break;
                    }
                    
                    
                }
                catch
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("diese eingabe ist ungültig");
                    Console.ResetColor();
                }
                try
                {
                    
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    repeat = false;
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.Write("Wollen sie ein anderes Fahrzeug nutzen? [true/false]");
                    repeat = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Diese eingabe ist nicht gültig");
                    Console.ResetColor();
                }
            }
            
        }
    }
}