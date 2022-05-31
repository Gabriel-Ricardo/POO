using System; 
class URI {

    public static void Main(string[] args) { 
        
        string nomeVendedor = Console.ReadLine();
        
        double salarioFixo = double.Parse(Console.ReadLine());

        double vendaMensal = double.Parse(Console.ReadLine());

        Console.WriteLine($"TOTAL = R$ {((salarioFixo) + (15 * vendaMensal)/100):0.00}");
        
    }

}