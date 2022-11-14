 using System;

class Program {
  public static void Main() {
  DateTime dt = new DateTime(2022, 11, 09);

  ValeCompra vale = new ValeCompra(dt.AddDays(10), 200);
  Produto produto = new Produto("Creme de cabelo SEDA", 13);

  Premio premio1 = new Premio("Débora", dt);
  Premio premio2 = new Premio("Lavínia", dt);
  premio1.SetPremio(vale);
  premio2.SetPremio(produto);

    
  Console.WriteLine(premio1.ToString());
  Console.WriteLine(premio2.ToString());
  }
}

class Premio{
  private string cliente;
  private DateTime dt;
  private object premioescolhido;

  public Premio(string c, DateTime d){
    this.cliente = c;
    this.dt = d;
  }
  public override string ToString(){
    return $" -------- PREMIO -------- \n {this.premioescolhido} \n ------------------------ \n Cliente: {this.cliente} \n Data: {this.dt} \n ------------------------ \n";
  }
  public void SetPremio(object p){
    this.premioescolhido = p;
  }
  public object GetPremio(){
    return this.premioescolhido;
  }
}

class ValeCompra{
  private DateTime dataValidade;
  private int valor;

  public ValeCompra(DateTime d, int v){
    this.dataValidade = d;
    this.valor = v;
  }
  public override string ToString(){
    return $"Vale compras valido até {this.dataValidade} \n Valor: R$ {this.valor},00";
  }
}

class Produto{
  private string descricao;
  private int valor;

  public Produto(string d, int v){
    this.descricao = d;
    this.valor = v;
  }
  public override string ToString(){
    return $"Produto: {this.descricao} \n Valor: R$ {this.valor},00";
  }
}

