using System;
class MainClass {
  public static void Main(string[] args) {

    Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\" ");

    string timeInterval = Console.ReadLine();

    string[] timeIntervalSeparated = timeInterval.Split(':');

    double timeIntervalHours = double.Parse(timeIntervalSeparated[0]);

    double timeIntervalMinutes = double.Parse(timeIntervalSeparated[1]);

    double timeIntervalSeconds = double.Parse(timeIntervalSeparated[2]);

    Console.WriteLine($"A luz percorreu { ((timeIntervalSeconds) + (timeIntervalMinutes * 60) + (timeIntervalHours * 3600)) * 300000 } km nesse intervalo");
    
  }
}