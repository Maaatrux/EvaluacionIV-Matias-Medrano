using Evaluacion4.Models;

Console.WriteLine("Evaluación 4 - Matías Medrano");

using (EFContext db = new EFContext())
{
    /* 1) Obtener cursos cuyos NroSala estén entre 101 y 103,
          ordenados por NroSala de forma descendente 
     * SELECT * FROM Curso WHERE NroSala >= 101 AND NroSala <= 103 ORDER BY NroSala DESC; */
    var cursosOrdenados = db.Cursos
        .Where(x => x.NroSala >= 101 && x.NroSala <= 103)
        .OrderByDescending(x => x.NroSala)
        .ToList();

    Console.WriteLine("\nLista de cursos ordenados en forma descendente: ");
    foreach (var cursos in cursosOrdenados)
    {
        Console.WriteLine($"ID: {cursos.Id} - Descripción: {cursos.Descripcion} - Nro Sala: {cursos.NroSala} - Fecha Creación: {cursos.FechaCreacion.ToString("dd-MM-yyyy")}");
    }

    /* 2) Obtener el promedio de la edad de los alumnos
     * SELECT AVG(Edad) FROM Alumno; */
    double promedioEdad = db.Alumnos.Average(x => x.Edad);
    Console.WriteLine($"\nEl promedio de la edad de los alumnos es: {promedioEdad} ");

    /* 3) Obtener un sólo curso a través de su FechaCreacion (2022-07-26 17:26:22)
     * SELECT * FROM Curso WHERE FechaCreacion = '2022-07-26 17:26:22';  */

    var cursoPrimer = db.Cursos.FirstOrDefault(x => x.FechaCreacion == DateTime.Parse("2022-07-26 17:26:22"));
    Console.WriteLine($"\nEl primer registro es: ");
    Console.WriteLine($"ID: {cursoPrimer.Id} - Descripción: {cursoPrimer.Descripcion} - Nro Sala: {cursoPrimer.NroSala} - Fecha Creación: {cursoPrimer.FechaCreacion.ToString("dd-MM-yyyy")}");

    /* 4) Insertar un nuevo curso sin un ID existente aun, que posea
          las siguientes características:
          Descripción: "Cuarto Básico", NroSala: 104, FechaCreacion: El 29 de julio del 2022
          No se poseen datos si esta Activo o no. 
     * INSERT INTO Curso (Descripcion, NroSala, FechaCreacion, Activo)
     * VALUES ('Cuarto Básico',104,'2022-07-29',null);
    
    Curso nuevoCurso = new Curso()
    {
        Id = 0,
        Descripcion = "Cuarto Básico",
        NroSala = 104,
        FechaCreacion = Convert.ToDateTime("2022-07-29"),
        Activo = null
    };

    db.Cursos.Add(nuevoCurso);
    db.SaveChanges();
    */

    /* 5) Actualizar el nombre del Alumno "Raimundo Battle" a "Carlos Carvajal" y su edad de 6 a 7 años
          a través de la búsqueda de su Id
     * UPDATE alumno SET Nombre = 'Carlos Carvajal', Edad = 7 WHERE Id = 1;
     
     var alumnoEditar = db.Alumnos.FirstOrDefault(x => x.Id == 1);
     alumnoEditar.Nombre = "Carlos Carvajal";
     alumnoEditar.Edad = 7;

     db.Alumnos.Update(alumnoEditar);
     db.SaveChanges(); 
     */

    /* 6) Eliminar el Alumno "Luisa Jodar"
         a través de la búsqueda de su Id (20)
     * DELETE FROM Alumno WHERE Id = 20;
     var alumnoEliminar = db.Alumnos.FirstOrDefault(x => x.Id == 20);

     db.Alumnos.Remove(alumnoEliminar);
     db.SaveChanges();
     */
}