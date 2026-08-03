using System;

namespace Entrevista{
public partial class Programa{	
static void MostrarRechazados(){
			
    Console.WriteLine("Postulantes Rechazados:");

        for (int i=0;i< cantEstudiantes;i++){
           if (CalcularPromedio(Postulantes[i])< 5){
                    Console.WriteLine(Postulantes[i].Legajo + " - " + Postulantes[i].Nombre + " " + Postulantes[i].Apellido);
  }
  }
}}}