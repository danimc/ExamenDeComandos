
using System;
using System.Collections;

namespace examen
{
	
		class cuestionario
    	{
		public static void Main(string[] args)
     		{
			string resp;
			
			int[] nAlumno = new int[]{3,6,1,2,8,5,9,10,11,4,7,12,13,14,15,16};
			string[] respuesta = new string[] {"cmd","date","cd..","chdir..","title Barra Brava",
											   "cls","exit","md","mkdir chona","edit pd.txt",
											   "type pd.txt","copy /?","copy pd.txt c:\\users\\examen","del pd.txt","erase",
											   "comp archivo1 archivo2 /d","dir","rd chona","xcopy"};
									
			Hashtable alumno = new Hashtable();
			alumno.Add(1,"Aguilar Gonzalez Cesar Basilio");
			alumno.Add(2,"Aldrete Jimenez Carlos");
			alumno.Add(3,"Arriaga Valencia Jose Pablo");
			alumno.Add(4,"Blas Navarro Carlos Adrian");
			alumno.Add(5,"Bandala Alvarez Juan Carlos");
			alumno.Add(6,"Casillas Carvajal Alberto");
			alumno.Add(7,"Castellanos Cisneros Ana Alejandra");
			alumno.Add(8,"Huertas Rosales David Eduardo");
			alumno.Add(9,"Mora Carbajal Luis Daniel");
			alumno.Add(10,"Ochoa Gutierrez Daniel");
			alumno.Add(11,"Jimenez Murillo Jeane Citlaly");
			alumno.Add(12,"Trujillo Borja Eduardo");
			alumno.Add(13,"Cerda Beltran Jorge");
			alumno.Add(14,"Guerrero Garcia Karlos Alexander");
			alumno.Add(15,"De Santos Meras Jesus");
			alumno.Add(16,"Arturo Lobo");
			alumno.Add(17,"Arturo Darks");
			
			Hashtable preguntas = new Hashtable();
			preguntas.Add(0,"Comando utilizado para abrir una nueva instancia de consola");
			preguntas.Add(1,"Comando que muestra y configura la fecha ");
			preguntas.Add(2,"Regresa un directorio atras (C:\\>)");
			preguntas.Add(3,"Regresa un directorio atras con otro comando diferente a CD");
			preguntas.Add(4,"Nombra la ventana del CMD \"Barra Brava\"");
			preguntas.Add(5,"Comando para limpiar pantalla");
			preguntas.Add(6,"Comando para salir del CMD.exe");
			preguntas.Add(7,"Comando corto para crear una carpeta o directorio");
			preguntas.Add(8,"Crea una carpeta llamada \"chona\" sin usar el comando MD");
			preguntas.Add(9,"Edita el contenido del archivo \"pd.txt\"");
			preguntas.Add(10,"Muestra el contenido del archivo \"pd.txt\"");
			preguntas.Add(11,"Muestra la ayuda del comando para copiar un archivo");
			preguntas.Add(12,"Copia el archivo pd.txt al directorio \"examen\" que se encuentra en c:\\users, con ruta absoluta");
			preguntas.Add(13,"Elimina el archivo \"pd.txt\" con un comando corto");
			preguntas.Add(14,"Ingresa otro comando ademas de DEL que sirva para eliminar uno o mas archivos");
			preguntas.Add(15,"Compara el \"archivo1\" y el \"archivo2\" y muestra sus diferencias en formato decimal");
			for(int i = 0; i<=12;i++){
				int turno = nAlumno[i];
				Console.WriteLine("\n El siguiente es: \n \t{0}", alumno[turno] );
				Console.ReadKey(true);
				Console.WriteLine("{0}", preguntas[i] );
				Console.Write("C:\\users> ");
				resp = Console.ReadLine();
				if(resp == respuesta[i]){
					Console.WriteLine("Correcto!");					
				}else{
					Console.WriteLine("Incorrecto!");
					Console.Write("La respuesta correcta era... ");
					Console.ReadKey(true);
					Console.WriteLine("{0}",respuesta[i]);
				}
				Console.ReadKey(true);
				Console.Clear();
				                                                
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