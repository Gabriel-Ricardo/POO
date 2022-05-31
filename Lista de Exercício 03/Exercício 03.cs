using System;
class URI {
  public static void Main(string[] args) {
    double distancia = double.Parse(Console.ReadLine());

    double combustivel = double.Parse(Console.ReadLine());
    
    Console.WriteLine($"{(distancia/combustivel):0.000} km/l");
  }
}