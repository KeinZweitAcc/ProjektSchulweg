using Azure;
using Azure.Core.GeoJson;
using Azure.Maps.Routing;
using Azure.Maps.Routing.Models;
using Azure.Maps.Search;
using Azure.Maps.Search.Models;

namespace Schulweg
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool repeat = true;
            String Fahrzeug = "";
            bool eingabe = false;
            bool eingabe2 = false;


            while (repeat == true)
            {

                Fahrzeug = FahrzeugAuswahl(Fahrzeug);

                do
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        eingabe = false;

                        Console.Write("Wie lautet Ihr Wohnort? ");
                        string wohnort = Console.ReadLine();

                        Console.Write("Wie lautet Ihr Zielort? ");
                        string zielort = Console.ReadLine();

                        double wegLänge = await BerechneDistanzAsync(wohnort, zielort);

                        eingabe = true;

                        switch (Fahrzeug.ToLower())
                        {
                            case "töff":
                            case "toeff":
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Wie teuer ist ihr Töff? ");
                                double Preis = Convert.ToDouble(Console.ReadLine());
                                eingabe2 = true;
                                double kaufpreis = Preis / (10 * 378 * wegLänge);
                                double benzinPreis = 1.94 / 25;
                                double untersuchungsKosten = 150 / (378 * wegLänge);
                                double autoBahn = 40 / (378 * wegLänge);
                                double ölWechsel = 60 / (378 * wegLänge);
                                double gesamtkosten = kaufpreis + benzinPreis + untersuchungsKosten + autoBahn + ölWechsel;
                                Console.WriteLine("Mit dem Töff müssen sie per Kilometer {0} Franken bezahlen", gesamtkosten);
                                break;

                            case "auto":
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Wie viel kostet das Auto? ");
                                double autoPreis = Convert.ToDouble(Console.ReadLine());
                                eingabe2 = true;
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

                            case "evelo":
                            case "elektrovelo":
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Wie viel kostet ihr ElektroVelo? ");
                                double kosten = Convert.ToDouble(Console.ReadLine());
                                eingabe2 = true;
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
                    catch (Exception ex)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Diese Eingabe ist nicht gültig");
                        Console.ResetColor();

                    }
                }
                while (eingabe == false || eingabe2 == false);

                eingabe = false;

                repeat = Repeat();


            }

        }
        static string FahrzeugAuswahl(string Fahrzeug)
        {
            bool eingabe = false;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Mit welchem Transportmittel wollen sie zur Schule fahren? [");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Auto");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Töff");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Evelo");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("] ");

                    Fahrzeug = Console.ReadLine();
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    switch (Fahrzeug.ToLower())
                    {
                        case "töff":
                        case "toeff":
                        case "auto":
                        case "evelo":
                        case "elektrovelo":
                            eingabe = true;
                            break;
                        default:
                            throw new Exception();
                            break;
                    }

                    

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Diese eingabe ist ungültig");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.ResetColor();
                }
            }
            while (eingabe == false);

            return Fahrzeug;

        }
        static bool Repeat()
        {

            bool repeat = true;
            bool eingabe = false;

            do
            {
                try
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    repeat = false;
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.Write("Wollen sie ein anderes Fahrzeug nutzen? [");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("true");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("false");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("] ");

                    repeat = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    eingabe = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Diese Eingabe ist nicht gültig");
                    Console.ResetColor();
                }

            }
            while (eingabe == false);

            return repeat;
        }
        static async Task<double> BerechneDistanzAsync(string wohnort, string zielort)
        {
            wohnort += ", Schweiz";
            zielort += ", Schweiz";
            AzureKeyCredential credential = new AzureKeyCredential("EMBpFvkjHh1SrKTb16bVYz35-rzqxoY4MWyvdhTFbc4");
            MapsSearchClient searchClient = new MapsSearchClient(credential);
            MapsRoutingClient routingClient = new MapsRoutingClient(credential);
            Response<SearchAddressResult> badenResult = await searchClient.SearchAddressAsync(zielort);
            Response<SearchAddressResult> zuhauseResult = await searchClient.SearchAddressAsync(wohnort);

            List<GeoPosition> routePoints = new List<GeoPosition>()
            {
                badenResult.Value.Results[0].Position,
                zuhauseResult.Value.Results[0].Position
            };

            RouteDirectionQuery query = new RouteDirectionQuery(routePoints);
            Response<RouteDirections> result = routingClient.GetDirections(query);

            double wegLänge = (int)result.Value.Routes[0].Summary.LengthInMeters;
            wegLänge /= 1000;

            Console.WriteLine("Distanz in Kilometer: " + wegLänge);
            Console.WriteLine("Reisezeit: " + result.Value.Routes[0].Summary.TravelTimeDuration);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            return wegLänge;

        }
    }
}