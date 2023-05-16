namespace exercicio01;
class Gato:Animal
{
    public virtual string Fala(){
        return base.Fala() + "Miau";
    }

}