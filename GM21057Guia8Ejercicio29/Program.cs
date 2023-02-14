using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Guía:8
// Ejercicio:29
// Fecha: 28/4/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia8Ejercicio29
{
	//Descripcion del programa:
	//Desplegar por pantalla las tablas de multiplicar del 1 al 9.	

	class Program
	{
		public static void Main(string[] args)
		{
			//Identificacion del programa en pantalla
			Console.Title = ("Desplegar por pantalla las tablas de multiplicar del 1 al 9. ");
			Console.WriteLine("Desplegar por pantalla las tablas de multiplicar del 1 al 9. ");
			Console.WriteLine("Autor:Brandon Gomez");

			//DECLARACION DE VARIABLES

			//ENTRADA DE DATOS
			double tabla1, tabla2, tabla3, tabla4, tabla5, tabla6, tabla7, tabla8, tabla9;
			tabla1 = 0; tabla2 = 0; tabla3 = 0; tabla4 = 0; tabla5 = 0; tabla6 = 0; tabla7 = 0; tabla8 = 0; tabla9 = 0;
			int i; i = 1;

			//PROCESO DE DATOS
			Console.WriteLine("|TABLA DEL 1|   |TABLA DEL 2|   |TABLA DEL 3|  |TABLA DEL 4|  |TABLA DEL 5|  |TABLA DEL 6|  |TABLA DEL 7|  |TABLA DEL 8|  |TABLA DEL 9|  ");
			for (i = 0; i <= 10; i++)
			{
				tabla1 = Tabla1(i); tabla2 = Tabla2(i); tabla3 = Tabla3(i); tabla4 = Tabla4(i); tabla5 = Tabla5(i); tabla6 = Tabla6(i); tabla7 = Tabla7(i); tabla8 = Tabla8(i); tabla9 = Tabla9(i);
				Console.WriteLine("  |1x{0:00}={1:00}|       |2x{0:00}={2:00}|       |3x{0:00}={3:00}|      |4x{0:00}={4:00}|      |5x{0:00}={5:00}|      |6x{0:00}={6:00}|      |7x{0:00}={7:00}|      |8x{0:00}={8:00}|      |9x{0:00}={9:00}|  ", i, tabla1, tabla2, tabla3, tabla4, tabla5, tabla6, tabla7, tabla8, tabla9);
			}

			//SALIDA DE DATOS
			Console.ReadKey();
		}
		public static double Tabla1(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 1;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla2(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 2;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla3(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 3;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla4(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 4;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla5(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 5;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla6(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 6;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla7(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 7;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla8(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 8;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
		public static double Tabla9(int i)
		{
			double total; total = 0;
			double multiplicando; multiplicando = 9;
			//i es la variable que almacena el multiplicador
			total = multiplicando * i;
			return total;
		}
	}
}

