// See https://aka.ms/new-console-template for more information
//using conceitosBasicos;
//using System.Security.Cryptography;

//int num1 = 20;
//int num2 = 11, result;


//Somador soma;
//soma = new Somador();

//result = soma.Soma(num1, num2);
//Console.WriteLine($"A soma dos números {num1} + {num2} é {result}");

//Conversor metrosMilimetros;
//metrosMilimetros = new Conversor();

//double resultm = Conversor.MetrosMilimetros(1.52);
//double metros = 1.76;
//Console.WriteLine("A medida {0} metros corresponde a {1} milimetros.",metros, Conversor.MetrosMilimetros(1.72));

using conceitosBasicos;

double inicial = 1500;
double percentual = 50, aumento, diferenca;

Calculadora calc;
calc = new Calculadora();

aumento = calc.CalculaAumento(inicial, percentual);
diferenca = calc.CalculaDiferenca(inicial, percentual);

Console.WriteLine($"Um aumento de {percentual}%, sobre o salário de {inicial}, é {diferenca}." +
    $"O seu novo salário será {aumento}");
