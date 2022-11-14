using System;

class Program {
  public static void Main() {
  DateTime dt = new DateTime(2003, 04, 09);
  Paciente p1 = new Paciente ("Lavinia", "131.136.244-44", "(84) 9 9921-8608", dt );
  Console.WriteLine(p1.ToString());
  }
}

class Paciente{
  private string nome;
  private string cpf;
  private string telefone;
  private DateTime nascimento;

  public Paciente(string n, string c, string t, DateTime nasc){
    this.nome = n;
    this.cpf = c;
    this.telefone = t;
    this.nascimento = nasc;
    
  }

  public string Idade(){
    DateTime hj = DateTime.Today;
    int anos = hj.Year - this.nascimento.Year;
    int meses = hj.Month - this.nascimento.Month;
    return $"Idade: {anos} anos e {meses} meses";
    
  }

  public override string ToString(){
    return $"---- PACIENTE ---- \n Nome: {this.nome} \n CPF: {this.cpf} \n Telefone: {this.telefone} \n Nasciemnto: {this.nascimento}" ;
  }

  public string getNome(){
    return this.nome;
  }
    public string getCpf(){
    return this.cpf;
  }
    public string getTelefone(){
    return this.telefone;
  }

  public void setNome(string n){
    this.nome = n;
  }
  public void setTelefone(string t){
    this.telefone = t;
  }
  public void setCpf(string c){
    this.cpf = c;
  }
  public void setNacimento(DateTime dt){
    this.nascimento = dt;
  }
} 