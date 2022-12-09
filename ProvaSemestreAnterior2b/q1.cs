using System;

class Program {
  public static void Main() {

  Empresa dlart = new Empresa();
    
   ContaPagar cp1 =  new ContaPagar{ 
    Fornecedor = "f1", 
    Vencimento =  DateTime.Parse("2022-04-09"),
    Valor = 10};
  
   ContaPagar cp2 =  new ContaPagar{ 
    Fornecedor = "f2", 
    Vencimento =  DateTime.Parse("2022-12-07"),
    Valor = 10};

  ContaPagar cp3 =  new ContaPagar{ 
    Fornecedor = "f3", 
    Vencimento =  DateTime.Parse("2022-03-07"),
    Valor = 10};

    dlart.Inserir(cp1);
    dlart.Inserir(cp2);
    dlart.Inserir(cp3);


     foreach(ContaPagar c in dlart.Listar()){
      Console.WriteLine(c);
  }
    
     foreach(ContaPagar c in dlart.Pesquisar(04, 2022)){
      Console.WriteLine(c);
  }
}

public class ContaPagar : IComparable {
  public string Fornecedor { get; set; }
  public DateTime Vencimento { get; set; }
  public double Valor { get; set; }

  public int CompareTo(object obj) {
    ContaPagar x1 = this;
    ContaPagar x2 = (ContaPagar) obj;
    return x1.Vencimento.CompareTo(x2.Vencimento);
  }
  
  public override string ToString(){
    return $"{Fornecedor} - {Valor}  |  {Vencimento:dd/MM/yyyy}";
  }
}
public  class Empresa{
  private ContaPagar[] contas;
  private int i = 1;
  
  public string Nome{ get; set; }
  public int Qtd { get; set; }

  public Empresa(){
    contas = new ContaPagar[1];
  }
 public void Inserir(ContaPagar c) {
    if (i == contas.Length)
      Array.Resize(ref contas, 1+ contas.Length);
      contas[i++] = c;
  }
  public ContaPagar[] Listar(){
    Array.Sort(contas);
    return contas;
  }
  public ContaPagar[] Pesquisar(int mes, int ano){
    int i = 0;
    ContaPagar[] contasMes = new ContaPagar[10];
    foreach(ContaPagar c in contas){
      if (c.Vencimento.Month == mes && 
          c.Vencimento.Year == ano){
        contasMes[i] = c;
        i++;
      }
    }
    return contasMes;
  }
  }
}
        