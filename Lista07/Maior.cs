using System;

class Program {
  public static void Main() {
    double a = double.Parse(Console.ReadLine());        
    double b = double.Parse(Console.ReadLine());    
    Console.WriteLine(Maior(a, b));
  }
  
   public static double Maior(double a, double b){
     double maior;
    if (a > b){
      maior = a;
    } else{
      maior = b;
    }
    return maior;
  }
}