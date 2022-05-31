using System;
class URI {
  public static void Main(string[] args) {

    int valor = int.Parse(Console.ReadLine());

    
    int cedulas100 = valor/100;
    int cedulas50 = (valor % 100)/50;
    int cedulas20 = ((valor % 100)%50)/20;
    int cedulas10 = (((valor % 100)%50)%20)/10;
    int cedulas5 = ((((valor % 100)%50)%20)%10)/5;
    int cedulas2 = (((((valor % 100)%50)%20)%10)%5)/2;
    int cedulas1 = ((((((valor % 100)%50)%20)%10)%5)%2)/1;

    
    Console.WriteLine( cedulas100 + "nota(s) de R$ 100,00");
    Console.WriteLine( cedulas50 + "nota(s) de R$ 50,00");
    Console.WriteLine( cedulas20 + "nota(s) de R$ 20,00");
    Console.WriteLine( cedulas10 + "nota(s) de R$ 10,00");
    Console.WriteLine( cedulas5 + "nota(s) de R$ 5,00");
    Console.WriteLine( cedulas2 + "nota(s) de R$ 2,00");
    Console.WriteLine( cedulas1 + "nota(s) de R$ 1,00");
  }
}