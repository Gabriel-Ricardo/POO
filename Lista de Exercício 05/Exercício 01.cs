using System;
class URI {
  public static void Main(string[] args) {

    int A = int.Parse(Console.ReadLine());
    int B = int.Parse(Console.ReadLine());
    int C = int.Parse(Console.ReadLine());
    int D = int.Parse(Console.ReadLine());


    if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0 ) {
      Console.WriteLine("Valores Aceitos");
      
    } else {
      Console.WriteLine("Valores não aceitos");
    }
    
  }
}