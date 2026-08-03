using System;

namespace Entrevista{
public partial class Programa{
static void CargarEntrevistas(){
    
    Console.Write("Ingrese el legajo del postulante: ");
    int legajoBuscado = Convert.ToInt32(Console.ReadLine());

    for(int i=0;i<cantEstudiantes;i++){
        if(Postulantes[i].Legajo == legajoBuscado){
    		
            Console.Write("Ingrese nota: ");
            Postulantes[i].Notas[Postulantes[i].totalNotas] =
                Convert.ToDouble(Console.ReadLine());

            Postulantes[i].totalNotas++;

            Console.Write("Ingrese observaciion de entrevista: ");
            Postulantes[i].Entrevistas[Postulantes[i].cantEntrevistas] =
                Console.ReadLine();

            Postulantes[i].cantEntrevistas++;

            Console.WriteLine("Entrevista cargada");
            return;
        }
    }
    Console.WriteLine("Postulante no encontrado.");
}}}
