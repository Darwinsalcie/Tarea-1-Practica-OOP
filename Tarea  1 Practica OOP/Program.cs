
using PersonasNamespace.Class;
using Figura.Class;

//se instancian los objetos
Persona opersona = new("Juan García", "Santo Domingo", new DateTime(2004, 06, 26));
Estudiante oestudiante = new Estudiante("Manuel Pérez", "Madrid", new DateTime(2004, 06, 26), "Ingeniería Informática", "A12345");
Rectangulo orectangulo = new Rectangulo("Rectangulo",18.08f, 45.3f);
Triangulo otriangulo = new Triangulo("Triangulo", 18.3f, 45.4f);
Circulo ocirculo = new Circulo("Circulo", 5.4f);

//se imprimen los objetos
Console.WriteLine(opersona);
Console.WriteLine(oestudiante.MostrarInformacionCompleta());
Console.WriteLine(orectangulo);
Console.WriteLine(otriangulo);
Console.WriteLine(ocirculo);


