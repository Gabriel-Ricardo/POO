using System;
class URI {
  public static void Main(string[] args) {

    int valor1 = int.Parse(Console.ReadLine());

    int valor2 = int.Parse(Console.ReadLine());

    int valor3 = int.Parse(Console.ReadLine());

    int valorFinal;

    
    if (valor1 > valor2) {
      valorFinal = valor1;
    } else {
      valorFinal = valor2;
    }

    if (valorFinal > valor3) {
      valorFinal = valorFinal;
    } else {
      valorFinal = valor3;
    }

    Console.WriteLine(valorFinal + " eh o maior");
  }
}