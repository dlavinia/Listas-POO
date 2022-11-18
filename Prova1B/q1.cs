 using System;

class Program {
  public static void Main() {

    int cont;
    Pais maiorD;
    Pais[] paises = new Pais[10];

    for (cont =0; cont < 10; cont++){
      
      string nome = Console.ReadLine();
      int pop = int.Parse(Console.ReadLine());
      double area =  double.Parse(Console.ReadLine());
      
      paises[cont] = new Pais(nome, pop, area);
    }

    maiorD = paises[0];
    
    for (cont =0; cont < 10; cont++){
      if(paises[cont].Densidade() > maiorD.Densidade()){
        maiorD = paises[cont];
      }
    }
      Console.WriteLine("** PAIS COM MAIOR DENSIDADE **");
      Console.WriteLine(maiorD.ToString());

}
}
class Pais{

  private string nome;
  private int populacao;
  private double area;

  public Pais(string n, int p, double a){
     if (n != ""){
      this.nome = n; 
    }
    if (p > 0){
      this.populacao = p; 
    }
     if (a > 0){
      this.area = a; 
    }
    
  }


  public double Densidade(){
    double densidade = this.populacao / this.area;
    return densidade;
  }

  public string GetNome(){
   return this.nome;
  }
  
  public int GetPopulacao(){
   return this.populacao;
  }
  
  public double GetArea(){
   return this.area;
  }

  public void SetNome(string n){
    if (n != ""){
      this.nome = n; 
    }
  }
  public void SetPopulacao(int p){
    if (p > 0){
      this.populacao = p; 
    }
  }
  public void SetArea(double a){
    if (a > 0){
      this.area = a; 
    }
  }

  public override string ToString(){
    return $"----- {this.nome} ----- \n População: {this.populacao} habitantes \n Área: {this.area} km2 \n ";
  }
}


