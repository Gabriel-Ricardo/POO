using System;
class MainClass {
  public static void Main(string[] args){
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");

    double firstBimesterGrade = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");

    double secondBimesterGrade = double.Parse(Console.ReadLine());

    double parcialAverage = ((firstBimesterGrade * 2) + (secondBimesterGrade * 3))/5;

    Console.WriteLine("Média parcial: " + parcialAverage);
  }
}