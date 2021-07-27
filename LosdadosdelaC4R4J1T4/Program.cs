/*
 * Created by SharpDevelop.
 * User: Virginia
 * Date: 27/07/2021
 * Time: 10:22 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LosdadosdelaC4R4J1T4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string cadena= ""; 
			string apellido;
			bool encender= true;  bool otro= true;
			string nombre;
			int edad;
			int cedula;
			string Direccion;
			char eleccion;	double saldotot= 500000.00; 
			int dado;
			int contajugada= 0;
			char seguir;
			Console.WriteLine("Bienvenido al programa mi pana");
			Console.WriteLine("Ingrese su nombre");
			nombre=Console.ReadLine();
		
			Console.WriteLine("Ingrese su apellido");
			apellido= Console.ReadLine();
			Console.WriteLine("Ingrese su edad");
			cadena= Console.ReadLine();
			Convert.ToInt32(cadena);
			edad= Convert.ToInt32(cadena);
			
			Console.WriteLine("Ingrese su numero de cédula");
			cadena= Console.ReadLine();
			cedula= Convert.ToInt32(cadena);
			
			Console.WriteLine("Ingrese su Dirección");
			Direccion= Console.ReadLine();
			
			Console.WriteLine("Bienvenido "+ nombre + " "+ apellido + " Usted posee un saldo Inicial de 500.000,00 bs");
			while (encender){
				
				Console.WriteLine("Leyenda del programa: s= Si       n=No");
				Console.WriteLine("Tirar el dado tiene un costo de 20.000,00 bs, Deseea tirarlo?");
				eleccion=char.Parse(Console.ReadLine());
			
				
				if ((eleccion !='s' && eleccion != 'n')){
					Console.WriteLine("Opcion no solicitada");
					
				}
				
				if(eleccion== 'n'){
						encender=false;
						Console.WriteLine("El jugador "+ " "+apellido +" no jugo y se quedo con su saldo inicial de "+ saldotot);
					}
				if (eleccion == 's'){
				saldotot= saldotot-20000.00;
				Console.WriteLine("Su saldo actual es "+ saldotot);
				Console.WriteLine("Ingrese el numero del dado que salió al lanzarlo");
				cadena= Console.ReadLine();
				dado= Convert.ToInt32(cadena);
					if((dado>6 && dado<1)){
					while( otro){
						Console.WriteLine("Error, ingrese de nuevo el numero");
						cadena= Console.ReadLine();
						dado= Convert.ToInt32(cadena);
						
						if(dado>=1 || dado<=6){
							otro =false;
						}
					}
				}
				if ((dado>=1 && dado<=6)){
					contajugada= contajugada+1;
					if(dado==1 || dado==6){
						saldotot=saldotot+ 40000.00;
						Console.WriteLine("Ha ganado +40000.00, su saldo hasta ahora es: "+ saldotot);	
						
					}
					else{ Console.WriteLine("Perdió el costo de esta jugada");}
				}
				
			
			}
				if(saldotot<20000.00){
					encender=false;
				}
				if (saldotot>=20000.00){
					Console.WriteLine("¿Desea seguir jugando?");
				seguir=char.Parse(Console.ReadLine());
				if (seguir== 's'){
					encender= true;
				}
				else if(seguir== 'n'){
					saldotot=saldotot*1;
					encender=false;
				}
				}
				
			///while:
			}
			Console.WriteLine("El jugador "+ nombre + " "+ apellido+ ", edad"+ edad+ ", numero de cedula"+ cedula+ ", su dirección: "+ Direccion+  ", Obtuvo "+ saldotot);
			Console.WriteLine("El numero de jugadas fue "+ contajugada);
			Console.ReadKey();
		}
	}
}

