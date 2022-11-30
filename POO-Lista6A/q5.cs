using System;

class Program {
  public static void Main() {
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    for (int i = 0; i < v.Length; i++)
    Console.WriteLine(v[i] + w[w.Length-1-i]);
    Console.ReadKey();
  }
}


        