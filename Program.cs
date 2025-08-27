using System;


namespace Conversor
{
    class Program
    {
        private static short escalaFinal;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("------------------------");
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("------------------------");

            Menu();
        }

        static void Menu()
        {            
            Console.WriteLine("Em qual escala está a temperatura?");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.WriteLine("3 - Kelvin");
            Console.WriteLine("4 - Sair");
            
            Console.Write("Resposta: ");
            short escalaIni = short.Parse(Console.ReadLine());

            if (escalaIni == 4)
            {
                System.Environment.Exit(0);
            }

            Console.WriteLine("");

            Console.WriteLine("Para qual escala você quer converter?");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.WriteLine("3 - Kelvin");
            

            Console.Write("Resposta: ");
            escalaFinal = short.Parse(Console.ReadLine());      
            
            if (escalaIni == 1 && escalaFinal == 1 || escalaIni == 1 && escalaFinal == 2 || escalaIni == 1 && escalaFinal == 3)
            {
                Celsius();
            }
            else if (escalaIni == 2 && escalaFinal == 1 || escalaIni == 2 && escalaFinal == 2 || escalaIni == 2 && escalaFinal == 3)
            {
                Fahrenheit();
            }
            else if (escalaIni == 3 && escalaFinal == 1 || escalaIni == 3 && escalaFinal == 2 || escalaIni == 3 && escalaFinal == 3)
            {
                Kelvin();
            }
            else
            {
                Menu();
            }

        }

        static void Celsius()
        {
            Console.Write("digite a temperatura: ");
            double temp = double.Parse(Console.ReadLine());

            double fahrenheit = (temp * 1.8) + 32;
            double kelvin = temp + 273;
            switch (escalaFinal)
            {
               case 1: Console.WriteLine($"Continua sendo {temp}°C, não precisou converter."); break;
               case 2: Console.WriteLine($"A temperatura convertida é {fahrenheit}°F."); break;
               case 3: Console.WriteLine($"A temperatura convertida é {kelvin}K."); break;
            }
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        static void Fahrenheit()
        {
            Console.Write("digite a temperatura: ");
            double temp = double.Parse(Console.ReadLine());

            double celsius = (temp - 32) / 1.8;
            double kelvin = (temp + 459.67) * 5 / 9;
            switch (escalaFinal)
            {
               case 1: Console.WriteLine($"A temperatura convertida é {celsius}°F."); break;
               case 2: Console.WriteLine($"Continua sendo {temp}°F, não precisou converter."); break;
               case 3: Console.WriteLine($"A temperatura convertida é {kelvin}K."); break;
               
            }
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        static void Kelvin()
        {
            Console.Write("digite a temperatura: ");
            double temp = double.Parse(Console.ReadLine());

            double celsius = temp - 273;
            double fahrenheit = (temp - 273.15) * 9 / 5 + 32;
            switch (escalaFinal)
            {
               case 1: Console.WriteLine($"A temperatura convertida é {celsius}°C."); break;
               case 2: Console.WriteLine($"A temperatura convertida é {fahrenheit}°F."); break;
               case 3: Console.WriteLine($"Continua sendo {temp}K, não precisou converter."); break;
               
            }
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
    }


}