using System;

class Program {
  public static void Main() {
  int n = int.Parse(Console.ReadLine());
  int ultimo, penultimo, termo;

  ultimo = 1;
  penultimo = 1;
  Console.WriteLine("0 1 1 "); 
    for (int i=3; n > i; i++){
      termo = ultimo+penultimo;
      penultimo = ultimo;
      ultimo = termo;
      Console.WriteLine($"{termo}");
      
      lista[i] = termo;
      
    }
  }
}