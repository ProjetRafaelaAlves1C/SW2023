namespace exercicio2;

class ContratoPF:Contrato
{
      public long CPF {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
          string Dados = this.Nome + "-" + this.Email + "-" + this.Celular + "-" + this.Idade + "-" + this.CPF;
          return Dados;
    }
}