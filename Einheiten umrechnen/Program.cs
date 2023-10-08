using System;

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
            double result = 0;

            if (quelleT == 1 && zielT == 2)
            {
                result = CelsiusToFahrenheit(temperature);
            }
            else if (quelleT == 2 && zielT == 1)
            {
                result = FahrenheitToCelsius(temperature);
            }
            else if (quelleT == 1 && zielT == 3)
            {
                result = CelsiusToKelvin(temperature);
            }
            else if (quelleT == 3 && zielT == 1)
            {
                result = KelvinToCelsius(temperature);
            }
            else if (quelleT == 2 && zielT == 3)
            {
                result = FahrenheitToKelvin(temperature);
            }
            else if (quelleT == 3 && zielT == 2)
            {
                result = KelvinToFahrenheit(temperature);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl der Einheiten.");
                return;
            }

            Console.WriteLine($"Ergebnis: {temperature} Einheit {GetUnitName(quelleT)} entsprechen {result} Einheit {GetUnitName(zielT)}");
        }

        static void ConvertMassUnits()
        {
            Console.WriteLine("\nBitte wählen Sie die Ausgangseinheit der Masse:");
            Console.WriteLine("1. Ton");
            Console.WriteLine("2. Kilogramm");
            Console.WriteLine("3. Gramm");

            int sourceUnit = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBitte wählen Sie die Ziel-Einheit der Masse:");
            Console.WriteLine("1. Ton");
            Console.WriteLine("2. Kilogramm");
            Console.WriteLine("3. Gramm");

            int targetUnit = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Massenwert ein: ");
            double mass = double.Parse(Console.ReadLine());
            double result = 0;

            if (sourceUnit == 1 && targetUnit == 2)
            {
                result = TonToKilogram(mass);
            }
            else if (sourceUnit == 2 && targetUnit == 1)
            {
                result = KilogramToTon(mass);
            }
            else if (sourceUnit == 1 && targetUnit == 3)
            {
                result = TonToGram(mass);
            }
            else if (sourceUnit == 3 && targetUnit == 1)
            {
                result = GramToTon(mass);
            }
            else if (sourceUnit == 2 && targetUnit == 3)
            {
                result = KilogramToGram(mass);
            }
            else if (sourceUnit == 3 && targetUnit == 2)
            {
                result = GramToKilogram(mass);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl der Einheiten.");
                return;
            }

            Console.WriteLine($"Ergebnis: {mass} Einheit {GetUnitName(sourceUnit)} entsprechen {result} Einheit {GetUnitName(targetUnit)}");
        }

        static void ConvertWeightUnits()
        {
            Console.WriteLine("\nBitte wählen Sie die Ausgangseinheit der Gewichtseinheit:");
            Console.WriteLine("1. Pfund");
            Console.WriteLine("2. Kilogramm");
            // Add more weight units as needed

            int sourceUnit = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBitte wählen Sie die Ziel-Einheit der Gewichtseinheit:");
            Console.WriteLine("1. Pfund");
            Console.WriteLine("2. Kilogramm");
            // Add more weight units as needed

            int targetUnit = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Gewichtswert ein: ");
            double weight = double.Parse(Console.ReadLine());
            double result = 0;

            if (sourceUnit == 1 && targetUnit == 2)
            {
                result = PoundsToKilograms(weight);
            }
            else if (sourceUnit == 2 && targetUnit == 1)
            {
                result = KilogramsToPounds(weight);
            }
            // Add more weight unit conversions as needed

            Console.WriteLine($"Ergebnis: {weight} Einheit {GetUnitName(sourceUnit)} entsprechen {result} Einheit {GetUnitName(targetUnit)}");
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
                // Add more unit names as needed
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


//The Code work but it shows some errors in Gewicht einheit result . 