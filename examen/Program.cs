/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 27/03/2014
 * Hora: 07:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace examen
{
	
		class cuestionario
    	{
		public static void Main(string[] args)
     		{
			string eleccion;
			
			int[] nAlumno = new int[11]{3,6,1,2,8,5,9,10,11,4,7
			};
									
			Hashtable alumno = new Hashtable();
			alumno.Add(1,"Aguilar Gonzalez Cesar Basilio");
			alumno.Add(2,"Aldrete Jimenez Carlos");
			alumno.Add(3,"Arriaga Valencia Jose Pablo");
			alumno.Add(4,"Blas Navarro Adrian");
			alumno.Add(5,"Bandala Alvarez Juan Carlos");
			alumno.Add(6,"Casillas Carvajal Alberto");
			alumno.Add(7,"Castellanos Cisneros Ana Alejandra");
			alumno.Add(8,"Huertas Rosales David Eduardo");
			alumno.Add(9,"Mora Carbajal Luis Daniel");
			alumno.Add(10,"Ochoa Gutierrez Daniel");
			alumno.Add(11,"Jimenez Murillo Jeane Citlaly");
			
			for(int i = 0; i<=10;i++){
				int turno = nAlumno[i];
				Console.WriteLine("El siguiente es {0}", alumno[turno] );
				Console.ReadKey(true);
				                                                
			}
			Console.ReadKey(true);
		}
			
			
					
		
		
	      public static void PrintKeysAndValues( Hashtable tabla )  {
    	  Console.WriteLine( "\tClave \t Nombre " );
    	  foreach ( DictionaryEntry de in tabla )
          Console.WriteLine( "\t{0}:\t{1}", de.Key, de.Value );
    	  Console.WriteLine();
   	}
	}
}