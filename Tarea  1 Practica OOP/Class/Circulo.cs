

namespace Figura.Class;

public class Circulo : Figura
{
    float area;
    public Circulo(string figura, float radio) : base(figura,radio)
    {
        

    }
    public override float calcularArea()
    {
        area = (float)(Math.PI * Math.Pow(radio,2));
        return area;
    }
}