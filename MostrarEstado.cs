using System;

namespace Entrevista{
public partial class Programa{
	
	static void MostrarEstado(){
       Console.WriteLine("Estados de postulantes:");

        for (int i=0; i<cantEstudiantes; i++){
        Postulantes[i].Estado = ObtenerEstado(Postulantes[i]);

    Console.WriteLine(Postulantes[i].Legajo + " - " + Postulantes[i].Nombre + " " + Postulantes[i].Apellido + " - Estado: " + Postulantes[i].Estado);
}
}
}}