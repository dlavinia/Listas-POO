using System;

class Program {
  public static void Main() {
  Retangulo r1 = new Retangulo(3, 4);
  Console.WriteLine(r1.ToString());
  }
}

class Retangulo{
  private double b;
  private double h;

  public Retangulo(double b, double h){
    if (b >0 && h>0){
      this.b = b;
      this.h = h;
    }
  }

  public double CalcArea(){
    double area;
    area = this.b*this.h;
    return area;
  }
  public double CalcDiagonal(){
    double diagonal;
    diagonal = (this.b*this.b)+(this.h*this.h);
    diagonal = Math.Sqrt(diagonal);
    return diagonal;
  }
  public void SetBase(double b){
    if (this.b > 0) this.b = b;
  }
  public void SetAltura(double h){
    if (this.h > 0) this.h = h;
  }
  public double GetBase(){
    return this.b;
  }
  public double GetAltura(){
    return this.h;
  }
public override string ToString(){
  return $"Base: {b} \nAltura: {h}";
}
}