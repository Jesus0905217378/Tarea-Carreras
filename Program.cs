using Tarea_Carreras.Clases;

int mangas = 3;

ClsRace carrera = new ClsRace();
carrera.PedirDatosCarrera();

/* Tuve el problema de que para la manga 2 y 3 la velocidad seguia aumentando 
  como si el carro no se detenia. Para reiniciar la velocidad actual a 0 agregue GetVelocidadActual1() a Carro.cs
*/
for (int i = 0; i < mangas; i++)
{
    Console.WriteLine($"Manga {i+1}");
    carrera.IniciarCarrera();
    Console.WriteLine($"----------------------------------");

}
//coloqué contador despues de los if de iniciarCarrera()
// y Ganador() para evaluar a los ganadores de las mangas 
carrera.Ganador();