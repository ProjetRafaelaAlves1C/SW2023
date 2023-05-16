namespace exercicio01;
class Cao:Animal
{
    public virtual string Fala(){
        return base.Fala() + "Au Au";
    }
}