

namespace PersonasNamespace.Class;
public class Estudiante : Persona
{
    private string carrera;
    private string matricula;


    public Estudiante(string nombre, string ciudad, DateTime bornDate, string carrera, string matricula) : base(nombre, ciudad, bornDate)
    {//se llama el constructor de la clase base para inciializar sus campos y hacerlo con la logica que tenían, nos ahorramos ponerlo ahí abajo como los demás

        this.carrera = carrera;
        this.matricula = matricula;

    }
    public string MostrarInformacionCompleta()
    {
        return $"{ToString()}, Carrera: {carrera}, Matrícula: {matricula}";
    }


}