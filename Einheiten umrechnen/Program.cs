using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Einheiten-Umrechner App ");

            while (true)
            {
                Console.WriteLine("\n Welche Rechnungsart wollen Sie rechnen:");
                Console.WriteLine("\n1. Temperatur umrechnen");
                Console.WriteLine("2. Masseinheiten umrechnen");
                Console.WriteLine("3. Gewichtseinheiten umrechnen");
                Console.WriteLine("4. Beenden");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Vielen Dank.Tschüsse ");
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
        } // the beginning of the code and 

        static void ConvertTemperature()
        {
            Console.WriteLine("\nBitte wählen Sie die Quelleinheit der Temperatur:");
            Console.WriteLine("\n1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");

            int quelle = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBitte wählen Sie die Zieleinheit der Temperatur:");
            Console.WriteLine("\n1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");

            int ziel = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Temperaturwert ein: ");
            double temperature = double.Parse(Console.ReadLine());
            double result = 0;

            if (quelle == 1 && ziel == 2)
            {
                result = CelsiusToFahrenheit(temperature);
            }
            else if (quelle == 2 && ziel == 1)
            {
                result = FahrenheitToCelsius(temperature);
            }
            else if (quelle == 1 && ziel == 3)
            {
                result = CelsiusToKelvin(temperature);
            }
            else if (quelle == 3 && ziel == 1)
            {
                result = KelvinToCelsius(temperature);
            }
            else if (quelle == 2 && ziel == 3)
            {
                result = FahrenheitToKelvin(temperature);
            }
            else if (quelle == 3 && ziel == 2)
            {
                result = KelvinToFahrenheit(temperature);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl der Einheiten.");
                return;
            }

            Console.WriteLine($"Ergebnis: {result} {unitName(ziel)}");
        } // quelle Einheit und result 
        //_________________________________________________________________________________________________________
        //static void ConvertMassUnits()
        //{
        //    Console.WriteLine("\nBitte wählen Sie die Quelleinheit der Mass:");
        //    Console.WriteLine("\n1. Kilometer");
        //    Console.WriteLine("2. Meter");
        //    Console.WriteLine("3. Zentimeter");
            

        //    int quelleM = int.Parse(Console.ReadLine());

        //    Console.WriteLine("\nBitte wählen Sie die Zieleinheit der Mass:");
        //    Console.WriteLine("\n1. Kilometer");
        //    Console.WriteLine("2. Meter");
        //    Console.WriteLine("3. Zentimeter");

        //    int zielM = int.Parse(Console.ReadLine());

        //    Console.Write("Geben Sie einen Wert ein: ");
        //    double mass = double.Parse(Console.ReadLine());
        //    double result = 0;

        //    if (quelleM == 1 && zielM == 2)
        //    {
        //        result = kilometerToMeter(mass);
        //    }
        //    else if (quelleM == 2 && zielM == 1)
        //    {
        //        result = meterToKilometer(mass);
        //    }
        //    else if (quelleM == 1 && zielM == 3)
        //    {
        //        result = kilometerToZentimeter(mass);
        //    }
        //    else if (quelleM == 3 && zielM == 1)
        //    {
        //        result = zentimeterToKilometer(mass);
        //    }
        //    else if (quelleM == 2 && zielM == 3)
        //    {
        //        result = meterToZentimeter(mass);
        //    }
        //    else if (quelleM == 3 && zielM == 2)
        //    {
        //        result = zentimeterToMeter(mass);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ungültige Auswahl der Einheiten.");
        //        return;
        //    }

        //    Console.WriteLine($"Ergebnis: {result} {unitName(ziel)}");
        //} // quelle Einheit und result 
    }//____________________________________________________________________________________________________________

        static void ConvertWeightUnits()
        {
            // Implementiere die Umrechnung von Gewichtseinheiten hier
            // Ähnlich wie bei der Temperaturumrechnung
        }
    //_____________________________________________________________________________________________________________
        static string unitName(int unit)
        {
            switch (unit)
            {
                case 1:
                    return "Celsius";
                case 2:
                    return "Fahrenheit";
                case 3:
                    return "Kelvin";
                case 1:
                return "Kilometer";
                case 2:
                return "meter";
                case 3:
                return "Zentimeter";
            // Füge hier weitere Einheiten hinzu
            default:
                    return "Unbekannt";
            }
        } // Einheiten aufrufen und im Result hinzufügen 
    //_____________________________________________________________________________________________________________
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }   // einheiten rechnungen , die direkt zur ConvertTemperature klasse hinzufügen sollten

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
    //___________________________________________________________________________________
    //static double kilometerToMeter(double kilometer)
    //{
    //    return kilometer * 1000;
    //}
    //static double meterToKilometer(double kelvin)
    //{
    //    return kilometer / 1000; 
    //}
    //static double kilometerToZentimeter(double kilometer)
    //{
    //    return kilometer * 100000;
    //}
    //static double zentimeterToKilometer(double zentimeter)
    //{
    //    return zentimeter / 100000;
    //}
    //static double meterToZentimeter(double meter)
    //{
    //    return meter *100;
    //}
    //static double zentimeterToMeter(double zentimeter)
    //{
    //    return zentimeter  / 100;
    //}
    //____________________________________________________________________________________

}
}
