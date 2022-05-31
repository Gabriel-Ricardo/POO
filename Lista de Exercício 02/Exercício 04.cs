using System;
class MainClass {
  public static void Main(string[] args) {

    Console.WriteLine("Digite o valor da base e altura do triângulo:");

    double triangleBase = double.Parse(Console.ReadLine());

    double triangleHeight = double.Parse(Console.ReadLine());

    double triangleDiagonal = Math.Sqrt(Math.Pow(triangleBase, 2) + Math.Pow(triangleHeight, 2));
    
    Console.WriteLine($"Área = {(triangleBase * triangleHeight)/2:0.00} Perímetro = {(triangleBase * 2) + (triangleHeight * 2):0.00} Diagonal = {triangleDiagonal:0.00}");
    
  }
}