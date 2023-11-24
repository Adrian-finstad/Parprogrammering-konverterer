// See https://aka.ms/new-console-template for more information
//Lag et program som kan konvertere valuta, temperatur eller vekt
//Du skal kunne få alternativer for hva du vil konvertere, velge hva du vil konvertere til, og så skrive inn en verdi før du får svar i konsollen.

using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

 void main()
{

    Console.WriteLine("Velkommen! Ønsker du å konvertere valuta,vekt eller temperatur? Tast 1 for valuta, 2 for vekt og 3 for Tempratur.");
    var userInput = Console.ReadLine();
    if (userInput == "1")
    {
        currencyConverter();
    }
    else if (userInput == "2") {
        weigthConverter();
    } else if (userInput == "3") {
        temperatureConverter();
    }
    else
    {
        Console.WriteLine("Ugyldig");
        main();
    } 
}

void temperatureConverter()
{
    
    
    Console.WriteLine("Hvor mange Celcius vil du konvertere?");
    var convertTemperature = int.Parse(Console.ReadLine());
    double fahrenheit = (convertTemperature * 1.8) + 32;
    double kelvin = 273;
    Console.WriteLine("Vil du konvertere til fahrenheit (skriv 1), eller kelvin(skriv 2) eller  tast 3 for begge.");
    var userInput = Console.ReadLine();
    if (userInput == "1")
    {
        double newTemperature =  fahrenheit;
        Console.WriteLine($"{convertTemperature}Celcius er {newTemperature} fahrenheit ");
            main();
    } else if(userInput == "2")
    {
        double newTemperature =  convertTemperature +kelvin;
        Console.WriteLine($"{convertTemperature}Celcius er {newTemperature} kelvin ");
        main();
    } else if(userInput == "3") {

        double newTemperatureF =  fahrenheit;
        double newTemperatureK = convertTemperature + kelvin;
        Console.WriteLine($"{convertTemperature}Celcius er {newTemperatureF} fahrenheit og {newTemperatureK} kelvin ");
        main();
    }
    else
    {
        Console.WriteLine("Ugyldig");
        main();
    }
}


void weigthConverter()
{
    Console.WriteLine("hvor mange kilo vil du konvertere?");
    var convertWeight = int.Parse(Console.ReadLine());
    int kilo = 1;
    double pounds = 2.2;
    double stone = 0.15;
    Console.WriteLine("Vil du konvertere til pounds (skriv 1), eller stone(skriv 2) eller  tast 3 for begge.");
    var userInput = Console.ReadLine();

    if (userInput == "1")
    {
        double newWeight = convertWeight * pounds;
        Console.WriteLine($"Det blir {newWeight} pounds");
        main();
        
    }else if(userInput == "2")
    {
        double newWeight = convertWeight * stone;
        Console.WriteLine($"Det blir {newWeight} stone");
        main();
        
    } else if (userInput == "3")
    {
        double newWeightForPounds = convertWeight * pounds;
        double newWeightForStone = convertWeight * stone;
        Console.WriteLine($"Det blir {newWeightForPounds} pounds, og {newWeightForStone} stone");
        main();
        
    }
    else {
        Console.WriteLine("Ikke gyldig, vennligst prø på nytt");
            main();
             }
    
    
}

void currencyConverter()
{
    Console.WriteLine("Hvor mange kroner ønsker du å konvertere?");
    var convertAmount = int.Parse(Console.ReadLine());
    double USD = 0.093;
    double EUR = 0.085;
    Console.WriteLine("Vil du konvertere til USD eller EUR? Skriv inn 1 for USD, eller 2 for EUR");
    var userInput = Console.ReadLine();
    if (userInput == "1")
    {
        var newCurrency = convertAmount * USD;
        Console.WriteLine($"Det blir {newCurrency}Dollar!");
        main();
        

    }
    else if (userInput == "2")
    {
        var newCurrency = convertAmount * EUR;
        Console.WriteLine($"Det blir {newCurrency}Euro!");
        main();
        
    }
    else
    {
        Console.WriteLine("Invalid response, please try again");
        main();
        
    }

}

main();