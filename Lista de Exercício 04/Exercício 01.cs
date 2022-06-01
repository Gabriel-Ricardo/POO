using System;
class URI {
  public static void Main(string[] args) {

    double A = double.Parse(Console.ReadLine());
    double B = double.Parse(Console.ReadLine());
    double C = double.Parse(Console.ReadLine());

    //  double triangleArea = A * C;
    //  double circleArea = 3.14159 * Math.Pow(C, 2);
    //  double trapezoidArea = ((A + B) * C)/2;
    //  double squareArea = Math.Pow(B, 2);
    //  double rectangleArea = A * B;

    Console.WriteLine($"TRIANGULO: {((A * C)/2):0.000}");
    Console.WriteLine($"CÍRCULO: {(3.14159 * Math.Pow(C, 2)):0.000}");
    Console.WriteLine($"TRAPÉZIO: {(((A + B) * C)/2):0.000}");
    Console.WriteLine($"QUADRADO: {(Math.Pow(B, 2)):0.000}");
    Console.WriteLine($"RETANGULO: {(A * B):0.000}");
    
  }
}