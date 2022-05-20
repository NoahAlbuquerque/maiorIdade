using System;

class Program {
  public static void Main (string[] args) {
    /* Construa um algoritmo que leia o ano de nascimento de uma pessoa (AN) e mostre a sua
idade e, também verifique e mostre se essa pessoa já tem idade para votar (16 anos ou
mais) e se já pode conseguir a sua carteira de habilitação (18 anos ou mais). */

    double an, anAtual, idade;
    Console.WriteLine ("Informe seu ano de nascimento: ");
    an = double.Parse (Console.ReadLine());
    Console.WriteLine ("Informe o ano atual: ");
    anAtual = double.Parse (Console.ReadLine());
    
    idade = anAtual - an;
    Console.WriteLine("Sua idade é {0}", idade);

    if(idade < 16 )
    {
        Console.WriteLine("Você não tem idade para votar.");
    }
    else
    {
      Console.WriteLine("Você já pode votar e tirar sua habilitação.");
    }
  }
}