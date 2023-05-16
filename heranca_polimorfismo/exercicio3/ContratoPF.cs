namespace exercicio03;
class ContratoPF:Contrato
{

 public long CPF {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
          string Dados = this.Nome + "-" + this.Email + "-" + this.Celular + "-" + this.Idade + "-" + this.CPF;
          return Dados;
    }
public override double CalcPrestacao(){
    if (Idade <= 30)
    {
        return ((base.CalcPrestacao()/Prazo)+1);
    }
    else if (Idade <= 40) 
    {
        return ((base.CalcPrestacao()/Prazo)+2);
    }
    else if (Idade <= 50) 
    {
        return ((base.CalcPrestacao()/Prazo)+3);
    }
    else 
    {
        return ((base.CalcPrestacao()/Prazo)+4);
    }
}
  
}