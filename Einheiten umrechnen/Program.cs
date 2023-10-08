﻿using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einheiten-Umrechner App");

            while (true)
            {
                Console.WriteLine("\nBitte wählen Sie die Art der Umrechnung:");
                Console.WriteLine("1. Temperatur umrechnen");
                Console.WriteLine("2. Masseinheiten umrechnen");
                Console.WriteLine("3. Gewichtseinheiten umrechnen");
                Console.WriteLine("4. Beenden");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Vielen Dank.... Auf Wiedersehen ");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        ConvertTemperature();
                        break;
                    case 2:
                        ConvertMassUnits();
                        break;
                    case 3:
                        ConvertWeightUnits();
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                        break;
                }
            }
        }

        static void ConvertTemperature()
        {
            Console.WriteLine("\nBitte wählen Sie die Quelle-Einheit der Temperatur:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");

            int quelleT = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBitte wählen Sie die Ziel-Einheit der Temperatur:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");

            int zielT = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Temperaturwert ein: ");
            double temperature = double.Parse(Console.ReadLine());
            double resultT = 0;

            if (quelleT == 1 && zielT == 2)
            {
                resultT = CelsiusToFahrenheit(temperature);
            }
            else if (quelleT == 2 && zielT == 1)
            {
                resultT = FahrenheitToCelsius(temperature);
            }
            else if (quelleT == 1 && zielT == 3)
            {
                resultT = CelsiusToKelvin(temperature);
            }
            else if (quelleT == 3 && zielT == 1)
            {
                resultT = KelvinToCelsius(temperature);
            }
            else if (quelleT == 2 && zielT == 3)
            {
                resultT = FahrenheitToKelvin(temperature);
            }
            else if (quelleT == 3 && zielT == 2)
            {
                resultT = KelvinToFahrenheit(temperature);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl der Einheiten.");
                return;
            }

            Console.WriteLine($"Ergebnis: {temperature} Einheit {GetUnitName(quelleT)} entsprechen {resultT} Einheit {GetUnitName(zielT)}");
        }

        static void ConvertMassUnits()
        {
            Console.WriteLine("\nBitte wählen Sie die Quelle-Einheit der Masse:");
            Console.WriteLine("1. Ton");
            Console.WriteLine("2. Kilogramm");
            Console.WriteLine("3. Gramm");

            int quelleM = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBitte wählen Sie die Ziel-Einheit der Masse:");
            Console.WriteLine("1. Ton");
            Console.WriteLine("2. Kilogramm");
            Console.WriteLine("3. Gramm");

            int zielM = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Massenwert ein: ");
            double mass = double.Parse(Console.ReadLine());
            double resultM = 0;

            if (quelleM == 1 && zielM == 2)
            {
                resultM = TonToKilogram(mass);
            }
            else if (quelleM == 2 && zielM == 1)
            {
                resultM = KilogramToTon(mass);
            }
            else if (quelleM == 1 && zielM == 3)
            {
                resultM = TonToGram(mass);
            }
            else if (quelleM == 3 && zielM == 1)
            {
                resultM = GramToTon(mass);
            }
            else if (quelleM == 2 && zielM == 3)
            {
                resultM = KilogramToGram(mass);
            }
            else if (quelleM == 3 && zielM == 2)
            {
                resultM = GramToKilogram(mass);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl der Einheiten.");
                return;
            }

            Console.WriteLine($"Ergebnis: {mass} Einheit {GetUnitName(quelleM)} entsprechen {resultM} Einheit {GetUnitName(zielM)}");
        }

        static void ConvertWeightUnits()
        {
            Console.WriteLine("\nBitte wählen Sie die Quelle-Einheit der Gewichtseinheit:");
            Console.WriteLine("1. Pfund");
            Console.WriteLine("2. Kilogramm");
  
            int quelleG = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBitte wählen Sie die Ziel-Einheit der Gewichtseinheit:");
            Console.WriteLine("1. Pfund");
            Console.WriteLine("2. Kilogramm");

            int zielG = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Gewichtswert ein: ");
            double gewicht = double.Parse(Console.ReadLine());
            double resultG = 0;

            if (quelleG == 1 && zielG == 2)
            {
                resultG = PoundsToKilograms(gewicht);
            }
            else if (quelleG == 2 && zielG == 1)
            {
                resultG = KilogramsToPounds(gewicht);
            }
          
            Console.WriteLine($"Ergebnis: {gewicht} Einheit {GetUnitName(quelleG)} entsprechen {resultG} Einheit {GetUnitName(zielG)}");
        }

        static string GetUnitName(int unit)
        {
            switch (unit)
            {
                case 1:
                    return "Ton";
                case 2:
                    return "Kilogramm";
                case 3:
                    return "Gramm";
                case 4:
                    return "Celsius";
                case 5:
                    return "Fahrenheit";
                case 6:
                    return "Kelvin";
                case 7:
                    return "Pfund";
                default:
                    return "Unbekannt";
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        static double FahrenheitToKelvin(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9 + 273.15;
        }

        static double KelvinToFahrenheit(double kelvin)
        {
            return (kelvin - 273.15) * 9 / 5 + 32;
        }

        static double TonToKilogram(double ton)
        {
            return ton * 1000;
        }

        static double KilogramToTon(double kilogram)
        {
            return kilogram / 1000;
        }

        static double TonToGram(double ton)
        {
            return ton * 1_000_000;
        }

        static double GramToTon(double grams)
        {
            return grams / 1_000_000;
        }

        static double KilogramToGram(double kilogram)
        {
            return kilogram * 1000;
        }

        static double GramToKilogram(double grams)
        {
            return grams / 1000;
        }

        static double PoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        static double KilogramsToPounds(double kilograms)
        {
            return kilograms / 0.453592;
        }
    }
}
