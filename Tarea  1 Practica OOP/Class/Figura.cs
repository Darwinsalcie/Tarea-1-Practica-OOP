

namespace Figura.Class;

 public abstract class Figura
{   
    protected float factor;
    protected float área;
    protected float Base;
    protected float altura;
    protected float radio;

    protected string? figura;

    public Figura(string figura, float Base, float altura)
    {
        this.figura = figura;

        this.Base = Base;
        this.altura = altura;

     }

    public Figura(string figura, float radio)
    {
        this.figura = figura;
        this.radio = radio;
    }

    public virtual float calcularArea() 
    {
        área = Base*altura*factor;
        return área;

    }

    public override string ToString()
    {
        return $"El area del {figura} es: {calcularArea()}"; 
    }


}
