 using System;

class Program {
  public static void Main() {
  DateTime dtE = new DateTime(2022, 11, 09);
  DateTime dtV = new DateTime(2022, 12, 09);

  Boleto boleto1 = new Boleto("435421", dtE, dtV, 200);
  Console.WriteLine(boleto1.ToString());
  boleto1.Pagar(100);
  Console.WriteLine(boleto1.ToString());
  boleto1.Pagar(100);
  Console.WriteLine(boleto1.ToString());

  Console.WriteLine(boleto1.Situacao());

  }}

class Boleto{
  private string codBarras;
  private DateTime dataE;
  private DateTime dataV;
  private DateTime dataP;
  private decimal valorBoleto;
  private decimal valorPago;
  private Pagamento situacaoPagamento;

  public Boleto(string cod, DateTime emissao, DateTime venc, decimal valor){
    this.codBarras = cod;
    this.dataE =emissao;
    this.dataV = venc;
    this.valorBoleto = valor;
    this.valorPago = 0;
    this.situacaoPagamento = Pagamento.EmAberto;
  }
  public void Pagar(decimal valor){
    if ((valor+this.valorPago) < this.valorBoleto){
      this.valorPago += valor;
      this.dataP = DateTime.Today;
      this.situacaoPagamento = Pagamento.PagoParcial;
    }
    else if((valor+this.valorPago) == this.valorBoleto){
      this.valorPago += valor;
      this.dataP = DateTime.Today;
      this.situacaoPagamento = Pagamento.Pago;
    }
  }
  public Pagamento Situacao(){
    return this.situacaoPagamento;
  }

  public override string ToString(){
    return $"---------- BOLETO ---------- \n Código de barras: {this.codBarras} \n Data de Emissão: {this.dataE} \n Data de Vencimento:{this.dataV} \n Data de Pagamento: {this.dataP} \n Valor do Boleto: R$ {this.valorBoleto} \n Valor Pago: R$ { this.valorPago} \n Situação: {this.situacaoPagamento } \n \n";
  }
}


enum Pagamento:byte{
  EmAberto =1, 
  PagoParcial = 2,
  Pago = 3
}
