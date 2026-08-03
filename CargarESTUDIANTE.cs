using System;

namespace Entrevista{
public partial class Programa{
static void CargarPostulante(){
		
        if (cantEstudiantes >= Postulantes.Length){    
            return;
        }
                Console.Write("Nombre:");
                string Nombre = Console.ReadLine();
                Console.Write("Apellido:");
                string Apellido = Console.ReadLine();
                Console.Write("DNI:");
                string DNI = Console.ReadLine();
                Console.Write("Número de legajo:");
                int Legajo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Email:");
                string Email = Console.ReadLine();
                Console.WriteLine("Carrera:");
                string Carrera = Console.ReadLine();
                
             
                Postulantes[cantEstudiantes].Nombre = Nombre;
                Postulantes[cantEstudiantes].Apellido = Apellido;
                Postulantes[cantEstudiantes].DNI = DNI;
                Postulantes[cantEstudiantes].Legajo = Legajo;
                Postulantes[cantEstudiantes].Email = Email;
                Postulantes[cantEstudiantes].Carrera = Carrera;
              	Postulantes[cantEstudiantes].Notas = new double[5];
				Postulantes[cantEstudiantes].Entrevistas = new string[5];
				Postulantes[cantEstudiantes].totalNotas = 0;
				Postulantes[cantEstudiantes].cantEntrevistas=0;
                
                    cantEstudiantes++;
                    Console.WriteLine("Cargado");
        }
}}