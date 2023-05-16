namespace exercicio2;

class Contrato
{
     public string? Nome {get;set;}

   public string? Email {get;set;}

   public string? Celular {get;set;}

   public virtual string MostraDados(){
      string Dados = this.Nome + "-" + this.Email + "-" + this.Celular;
      return Dados;
   }
}