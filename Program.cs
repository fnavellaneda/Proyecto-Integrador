using System;

namespace Entrevista{
public partial class Programa{
struct postulante
 {
      public string Nombre;
      public string Apellido;
      public string DNI;
      public int Legajo;
      public string Carrera;
      public string Email;
      public double[]Notas;
      public int totalNotas;
      public string[]Entrevistas;
      public int cantEntrevistas;
      public double Promedio;
      public string Estado;
      }
     static postulante[] Postulantes = new postulante[100];
     static int cantEstudiantes=0;
     
public static void Main(){
          int opciones;
          do
      {
        Console.WriteLine("==== Menú ====");
        Console.WriteLine(" ");
        Console.WriteLine("1. Cargar datos de un postulante");
        Console.WriteLine("2. Calcular y mostrar puntajes promedios");
        Console.WriteLine("3. Mostrar postulantes no admitidos (promedio < 5)");
        Console.WriteLine("4. Mostrar postulantes a becas (promedio >= 8)");
        Console.WriteLine("5. Cargar entrevista anexas a un postulante");
        Console.WriteLine("6. Buscar postulante por número de legajo");
        Console.WriteLine("7. Administrar estado de postulante");
        Console.WriteLine(" ");
        Console.WriteLine("8. Salir del programa");
        Console.WriteLine(" ");
        Console.Write("Seleccione una opción: ");    
        
        opciones = Convert.ToInt32(Console.ReadLine());
          
        switch(opciones)
        {
    case 1: CargarPostulante(); break;
    case 2: CalcularPromedios(); break;    
    case 3: MostrarRechazados(); break;
    case 4: MostrarBecados(); break;
    case 5: CargarEntrevistas(); break;
    case 6: BuscarPorLegajo(); break;
    case 7: MostrarEstado(); break;
       default: 
        Console.WriteLine("Ingrese una opción valida");
        break;
 }
        if(opciones !=8) {
        	Console.ReadKey();
        	Console.Clear();
        }
      } while(opciones !=8);
    } 
}}
