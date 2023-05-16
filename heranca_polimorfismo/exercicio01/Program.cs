namespace exercicio01;
class Program
{
    static void Main(string[] args)
    {
         Cao c = new Cao();
         Gato g = new Gato();
         Homem h = new Homem();
         Animal a = new Animal();

        Console.WriteLine("O HOMEM fala: " + h.Fala());
        Console.WriteLine("O CÃO fala: " + c.Fala());
        Console.WriteLine("O GATO fala: " + g.Fala());
    }
}
