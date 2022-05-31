using System;
class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome completo:")
    string fullName = Console.ReadLine();

    string[] fullNameSeparated = fullName.Split(' ');

    Console.WriteLine("Bem-vindo ao C#, " +fullNameSeparated[0]);
  }
}