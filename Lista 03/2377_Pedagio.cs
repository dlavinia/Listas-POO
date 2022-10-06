
using System;

class Program {
  public static void Main() {
    int l, d, k, p, custo;
    string l1 = Console.ReadLine();
    string l2 = Console.ReadLine();

    string[] x = l1.Split();
    string[] y = l2.Split();

    l = int.Parse(x[0]);
    d = int.Parse(x[1]);

    k = int.Parse(y[0]);
    p = int.Parse(y[1]);
    
    custo = (l * k) + ((l / d) * p);

    Console.WriteLine(custo);

  }
}