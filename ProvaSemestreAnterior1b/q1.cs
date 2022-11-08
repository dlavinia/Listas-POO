using System;

class Program {
  public static void Main() {
    int cont;
    Pais[] paises = new Pais[10];

    for (cont =0; cont < 10; cont++){
      string nome = Console.ReadLine();
      long pop = long.Parse(Console.ReadLine());
      
      paises[cont] = new Pais(nome, pop);
    }
  }

}

class Pais{
  private string nome;
  private long populacao;

  public Pais() { }
  public Pais(string n, long p){
    if (!String.IsNullOrEmpty(n))this.nome=n;
    if (p > 0) this.populacao=p;
    
  }
  public string GetNome(){ return this.nome;}
  public long GetPopulacao(){ return this.populacao;}

  public void SetNome(string n){
     if (!String.IsNullOrEmpty(n)) this.nome=n;
  }
  public void SetPopulacao(long p){
    if (p>0) this.populacao=p;
  }

  public override string ToString(){
    return $"o Pais {nome} tem {populacao} habitantes";
  }
}
        