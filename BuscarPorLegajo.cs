using System;

namespace Entrevista{
public partial class Programa{
		
static void BuscarPorLegajo()
  {
  Console.Write("Ingrese legajo: ");
  int legajoBuscado = Convert.ToInt32(Console.ReadLine());
  
          for (int i = 0; i < cantEstudiantes; i++){
        if (Postulantes[i].Legajo == legajoBuscado){
            Console.WriteLine("Nombre: " + Postulantes[i].Nombre);
            Console.WriteLine("Apellido: " + Postulantes[i].Apellido);
            Console.WriteLine("DNI: " + Postulantes[i].DNI);
            Console.WriteLine("Carrera: " + Postulantes[i].Carrera);
            Console.WriteLine("Email: " + Postulantes[i].Email);
            Console.WriteLine("Promedio: " + CalcularPromedio(Postulantes[i]));
            Console.WriteLine("Estado: " + ObtenerEstado(Postulantes[i]));
            Console.WriteLine("Observacion:");

			for(int o=0;o < Postulantes[i].cantEntrevistas;o++){
    		Console.WriteLine("" + Postulantes[i].Entrevistas[o]);
            }
            return;
   }
   }
        Console.WriteLine("Postulante no encontrado");
   }
}}