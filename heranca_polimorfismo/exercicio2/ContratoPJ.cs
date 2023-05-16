namespace exercicio2;

class ContratoPJ:Contrato
{
    public long Inscricao {get;set;}

    public long CNPJ {get;set;}


    public override string MostraDados(){
        string Dados = this.Nome + "-" + this.Email + "-" + this.Celular + "-" + this.CNPJ + "-" + this.Inscricao;
        return Dados;
    }
}