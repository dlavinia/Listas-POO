using System;

class Program {
  public static void Main() {
    
    string x = Console.ReadLine();
    float n = float.Parse(x);

    if ((n >= 0) && (n <= 25.0000)){
          Console.WriteLine("Intervalo [0,25]");
    }
    if ((n >= 25.0001) && (n <= 50.0000)){
      Console.WriteLine("Intervalo [25, 50]");
    }
    if ((n >= 50.0001) && (n <= 75.0000)){
      Console.WriteLine("Intervalo [50,75]");
    }
    if ((n >= 75.0001) &&  (n <= 100.0000)){
      Console.WriteLine("Intervalo [75, 100]");
    }
    if( (n < 0) || (n > 100.0000)){
      Console.WriteLine("Fora de intervalo");
    }
  }
}