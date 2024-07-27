

namespace Figura.Class;

public class Triangulo : Figura
{
    public Triangulo(string figura, float Base, float altura) : base(figura, Base, altura)
    {
        this.factor = 1f/2f;   //es igual a dividir entre 2 

    }
    public override float calcularArea()
    {
        return base.calcularArea();
    }
}