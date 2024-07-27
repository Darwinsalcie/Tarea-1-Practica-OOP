


namespace Figura.Class;

public class Rectangulo : Figura
{
    public Rectangulo(string figura, float Base, float altura) : base(figura, Base, altura) 
    {
        this.factor = 1;

    }
    public override float calcularArea()
    {
        return base.calcularArea();
    }
}