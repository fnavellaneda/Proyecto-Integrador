using System;

namespace Entrevista{
public partial class Programa{
static void MostrarBecados()
        {
      Console.WriteLine("Postulantes a beca:");

      for (int i=0;i<cantEstudiantes;i++){
      if (CalcularPromedio(Postulantes[i]) >= 8){
    Console.WriteLine(Postulantes[i].Legajo + " - " + Postulantes[i].Nombre + " " + Postulantes[i].Apellido);
 }
 }
}
}}