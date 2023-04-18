namespace atividadeJuros;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Banco banco = new Banco();

        banco.cliente ="Anderson";
        Console.Write(banco.cliente + " digite o valor do seu emprestimo:");
        banco.valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor empréstimo: "+ banco.valor);
        Console.WriteLine("Seus juros: "+ banco.juros);
        Console.WriteLine("Juros mensais: "+ banco.mensal);

        banco.saldo = 2000;
        
       /* 
       double saldo = banco.consultaSaldo;
        banco.limite = 300;
        banco.deposito(30);
        banco.deposito(30);
        banco.limite = 300;
        Console.WriteLine(banco.consultaSaldo());
        double saldo = banco.consultaSaldo;
        
        /*
        double saldo = banco.consultaSaldo;
        banco.limite = 1500;
        banco.saque();
        banco.deposito();*/

    }
}
