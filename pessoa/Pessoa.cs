namespace pessoa;
class Pessoa
{
    public Pessoa(){
        this.Nome = "Nada";
        this.Sobrenome = "Nada";
        this.Idade = 0;
    }
    public Pessoa(string nome, int idade){
        this.Nome = nome;
        this.Sobrenome = "Nada";
        this.Idade = idade;
    }

    private string? Nome {get;set;}
    private string? Sobrenome{get;set;}
    private int Idade{get;set;}
    
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    public void AlteraSobreNome(string sobrenome){
        this.Sobrenome = sobrenome;
    }
    public void AlteraIdade(int idade){
        this.Idade = idade;
    }
    public void Mostratudo(){
        Console.WriteLine("Nome: "+ this.Nome);
        Console.WriteLine("Sobrenome: " + this.Sobrenome);
        Console.WriteLine("Idade: "+ this.Idade);
    }
}
