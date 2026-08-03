using System;

namespace Entrevista
{
    public partial class Programa{
        static double CalcularPromedio(postulante x){
    			double suma = 0;

    	for(int i=0;i< x.totalNotas;i++){
		suma += x.Notas[i];
        
    	}
    return suma / x.totalNotas;
}

        static string ObtenerEstado(postulante x){
            double promedio = CalcularPromedio(x);

            if(promedio < 5)
                return "Rechazado";

            if(promedio >= 8)
                return "Becado";

            return "En evaluacion";
       }

        static void CalcularPromedios()
        {
            Console.WriteLine("Lista de promedios:");

            for (int i=0;i<cantEstudiantes;i++)
            {
            double promedio = CalcularPromedio(Postulantes[i]);
            
            Postulantes[i].Promedio = promedio;
            Console.WriteLine(
            	"Legajo: " + Postulantes[i].Legajo + 
            	" - " + Postulantes[i].Nombre + 
            	" " + Postulantes[i].Apellido +
            	" - Promedio: " + promedio +
            	" - Estado:" + Postulantes[i].Estado);
    }
  }
}}