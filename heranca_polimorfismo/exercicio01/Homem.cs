namespace exercicio01;
class Homem:Animal
{
    public virtual string Fala(){
        return base.Fala() + "Olá Mundo";
    }

}