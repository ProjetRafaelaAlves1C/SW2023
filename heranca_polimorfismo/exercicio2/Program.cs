namespace exercicio2;
class Program
{
    static void Main(string[] args)
    {
       Contrato c1 = new Contrato();
       ContratoPF pf = new ContratoPF();
       ContratoPJ pj = new ContratoPJ();

        pf.Nome = "Rafela";
        pf.Email = "rafaela@gmail.com";
        pf.Celular = "11954848344";
        pf.Idade = 24;
        pf.CPF = 12345611007;
        pj.Nome = "O CUBO";
        pj.Email = "ocubo@gmail.com";
        pj.Celular = "55558888";
        pj.CNPJ = 12247886483864;
        pj.Inscricao = 037689759148;

        Console.WriteLine(pf.MostraDados());
        Console.WriteLine(pj.MostraDados());
    }
}
