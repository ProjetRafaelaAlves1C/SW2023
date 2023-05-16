namespace exercicio03;
class ContratoPJ:Contrato
{
public long Inscricao {get;set;}

public long Cnpj {get;set;}
public override string MostraDados(){
          string Dados = this.Nome + "-" + this.Email + "-" + this.Celular + "-" + this.Cnpj + "-" + this.Inscricao;
          return Dados;
    }
public override double CalcPrestacao(){
    return ((base.CalcPrestacao()/Prazo)+3);
   }

  
}