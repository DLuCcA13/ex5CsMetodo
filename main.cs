/* Crie um método chamado MaiorNumero que receba dois inteiros como parâmetros e retorne o maior entre eles. */
using System;

class Program {
  static int MaiorNumero(int a, int b){
    if(a < b){
      return b;
    } else{
      return a;
    }
  }
  public static void Main (string[] args) {
    Console.WriteLine("Digite o primeiro numero: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    int n2 = int.Parse(Console.ReadLine());
    int maior = MaiorNumero(n1, n2);
    Console.WriteLine("O maior numero foi " + maior);
  }
}