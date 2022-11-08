using System;

class Program {
  public static void Main() {
  Frete r1 = new Frete(10, 120);
  Console.WriteLine(r1.ToString());
  }
}

class Frete{
  private double distancia;
  private double peso;

  public Frete(double distancia, double peso){
    if (distancia >0 && peso>0){
      this.distancia = distancia;
      this.peso = peso;
    }
  }

  public double CalcFrete(){
    double frete;
    frete = (this.distancia*this.peso)/100;
    return frete;
  }
  public void SetBase(double distancia){
    if (this.distancia > 0) this.distancia = distancia;
  }
  public void SetAltura(double peso){
    if (this.peso > 0) this.peso = peso;
  }
  public double GetBase(){
    return this.distancia;
  }
  public double GetAltura(){
    return this.peso;
  }
public override string ToString(){
  return $"Distancia: {distancia}Km \nAltura: {peso}Kg \nFrete: " + CalcFrete();
}
}