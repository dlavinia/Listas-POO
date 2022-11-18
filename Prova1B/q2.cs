 using System;

class Program {
  public static void Main() {

  int ladoEp1 = int.Parse(Console.ReadLine());
  int ladoDp1 = int.Parse(Console.ReadLine());
    

  int ladoEp2 = int.Parse(Console.ReadLine());
  int ladoDp2 = int.Parse(Console.ReadLine());
    
  PecaDomino p1 = new PecaDomino(ladoEp1, ladoDp1);
  PecaDomino p2 = new PecaDomino(ladoEp2, ladoDp2);
    
  Console.WriteLine(p1.ToString());
  Console.WriteLine(p2.ToString());
  Console.WriteLine(p1.Combinar(p2));
  }
}

class PecaDomino{
  private int ladoE;
  private int ladoD;

  public PecaDomino(int lado1, int lado2){
    if (lado1 <=6 && lado1 >= 1){
      this.ladoE = lado1;
    }
    if (lado2 <=6 && lado2 >= 1){
      this.ladoD = lado2;
    }
  }

  public bool Combinar(PecaDomino pd){
    bool combina = false;
    if (pd.GetLadoE() == this.ladoE || pd.GetLadoD() == this.ladoE  || pd.GetLadoD() == this.ladoD || pd.GetLadoE() == this.ladoD ){
      combina = true;
    }
    return combina;
  }

  public void SetLadoE(int lado1){
      if (lado1 <=6 && lado1 >= 1){
        this.ladoE = lado1;
      } 
  }
  public void SetLadoD(int lado2){
      if (lado2 <=6 && lado2 >= 1){
        this.ladoD = lado2;
      } 
  }

  public int GetLadoE(){
    return this.ladoE;
  }
  
  public int GetLadoD(){
    return this.ladoD;
  }

  

  public override string ToString(){
    return $" ------- \n| {this.ladoE} | {this.ladoD} | \n ------- \n";
  }
}

