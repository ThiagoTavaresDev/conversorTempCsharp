using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  EX CONVERSOR DE TEMPERATURAS

  Objetivo: Crie um conversor de temperaturas, o usuário poderá escolher para qual
  medida ele deseja converter, ex: celsius para kelvin, faça um menu de escolha 
  registre os valores do usuario e os resultados em variáveis, para isso faça os cálculos
  utilizando as formulas de conversão (C/5) = (F-32)/9 , C = K - 273
 

 
*/

namespace ConversorTemperaturas
{
    class Program
  {
    public double valorCelsius;
    public double valorKelvin;
    public double valorFahrenheit;
    public double resultado;
    public static void Main(string[] args)
    {
      Menu();
    


    }
  

    public static void Menu()
    {
      Console.WriteLine("Bem vindo ao conversor de temperaturas");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Digite para qual medida você deseja converter");
      Console.WriteLine("Op 1 -- Celsius para Fahrenheit");
      Console.WriteLine("Op 2 -- Celsius para Kelvin");
      Console.WriteLine("Op 3 -- Fahrenheit para Celsius");
      Console.WriteLine("Op 4 -- Fahrenheit para Kelvin");
      Console.WriteLine("Op 5 -- Sair da aplicação");

      short option = Convert.ToInt16(Console.ReadLine());

      if(option < 1 || option > 5)
      {
        Environment.Exit(0);

      }
      switch (option)
      {
        case 1:
          {
            CelsiusToFahrenheit();
            break;
          }
        case 2:
          {
            CelsiusToKelvin();
            break;
          }
        case 3:
          {
            FahrenheitToCelsius();
            break;
          }
        case 4:
         {
            FahrenheitToKelvin();
            break;
          }
      }
 
    }
    public static void CelsiusToFahrenheit()
    {
      Console.WriteLine("Digite seu valor de graus Celsius");
      double valorCelsius = double.Parse(Console.ReadLine());
      double resultado = (valorCelsius * 9 / 5) + 32;
      Console.WriteLine($"o valor convertido para fahrenheit é de: {resultado}");
      Console.ReadKey();
    }
    public static void CelsiusToKelvin()
    {
      Console.WriteLine("Digite seu valor de graus Celsius");
      double valorCelsius = double.Parse(Console.ReadLine());
      double resultado = (valorCelsius + 273);
      Console.WriteLine($"o valor convertido para Kelvin é de: {resultado}");
      Console.ReadKey();
    }
    public static void FahrenheitToCelsius()
    {
      Console.WriteLine("Digite seu valor de graus Fahrenheit");
      double valorFahrenheit = double.Parse(Console.ReadLine());
      double resultado = (5 *(valorFahrenheit - 32) / 9);
      Console.WriteLine($"o valor convertido para Celsius é de: {resultado}");
      Console.ReadKey();
    }
    public static void FahrenheitToKelvin()
    {
      Console.WriteLine("Digite seu valor de graus Fahrenheit");
      double valorFahrenheit = double.Parse(Console.ReadLine());
      double resultado = (5*(valorFahrenheit - 32) / 9) + 273;
      Console.WriteLine($"o valor convertido para Kelvin é de: {resultado}");
      Console.ReadKey();
    }
  }

}

