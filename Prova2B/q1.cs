using System;
using System.Collections;

class Program {
  public static void Main() {
    
    Equipe bra = new Equipe("Brasil");
    
    Jogador j1 = new Jogador("Neymar", 10, 3);
    Jogador j2 = new Jogador("Richarlison", 9, 5);
    Jogador j3 = new Jogador("Alisson", 1, 0);
    Jogador j4 = new Jogador("L Paqueta", 17, 2);

    bra.Inserir(j1);
    bra.Inserir(j2);
    bra.Inserir(j3);
    bra.Inserir(j4);
    
    Console.WriteLine(bra);

    Console.WriteLine("Listagem ordem Alfabetica");
    foreach(Jogador j in bra.Listar()) Console.WriteLine(j);
    
    //Console.WriteLine("Listagem ordem Numero da Camisa");
    //foreach(Jogador j in bra.Camisas()) Console.WriteLine(j);
    
  }
  public class Jogador : IComparable{
    private string nome;
    private int camisa;
    private int numGols;
    
    public string Nome {
      get { return nome; }
      set { nome = value; }
    }
        
    public int Camisa {
      get { return camisa; }
      set { camisa = value; }
    }
         
    public int Gols {
      get { return numGols; }
      set { numGols = value; }
    }

    public Jogador(string n, int c, int g){
      this.Nome = n;
      this.Camisa = c;
      this.Gols = g;
    }

    public override string ToString(){
      return $" Nome: {nome} \n Camisa: {camisa} \n Gols: {numGols} \n";
    }

    public int CompareTo(object obj) {
      Jogador j1 = this;
      Jogador j2 = (Jogador) obj;
      return j1.Nome.CompareTo(j2.Nome);
  }

  
}
  public class Equipe{
    private string pais;
    private Jogador[] jogs = new Jogador[1];
    private ComparadorCamisas CC = new ComparadorCamisas();
    private ComparadorNumGols CG = new ComparadorNumGols();
    private int i = 1;
    public string Pais {
      get { return pais; }
      set { pais = value; }
    } 
    
    public Equipe(string p){
      this.Pais = p;
    }
    public void Inserir(Jogador j) {
      if (i == jogs.Length){
        Array.Resize(ref jogs, 1+ jogs.Length);
        jogs[i++] = j;
      }
    }
    public Jogador[] Listar(){
      Array.Sort(jogs);
      return jogs;
    }

    public Jogador[] Camisas(){
      Array.Sort(jogs, CC);
      return jogs;
    }
        public Jogador[] Artilheiros(){
      Array.Sort(jogs, CG);
      return jogs;
    }

      
    public override string ToString(){
      return $" Pais: {pais} \n Quantidade de jogadores: {i-1} \n";
    }
  }

  class ComparadorNumGols : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.Gols.CompareTo(j2.Gols);
    }
  }

  class ComparadorCamisas : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.Camisa.CompareTo(j2.Camisa);
  }
}
}