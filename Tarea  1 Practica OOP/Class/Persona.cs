
namespace PersonasNamespace.Class;

public class Persona
{
    private string nombre;
    private int edad;
    private DateTime bornDate;
    private string ciudad;

    public Persona(string nombre, string ciudad, DateTime bornDate)
    {
        this.nombre = nombre;
        this.ciudad = ciudad;
        this.bornDate = bornDate;


    }

    public int Calcularedad()
    {
        edad = DateTime.Now.Year - bornDate.Year;
        return edad;

    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Edad: {Calcularedad()} años, Ciudad: {ciudad}, Fecha de nacimiento: {bornDate.ToString("yyyy-MM-dd")}";
    }

}




