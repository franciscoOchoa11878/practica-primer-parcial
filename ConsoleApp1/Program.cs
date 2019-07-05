using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adoptador _adoptador = new Adoptador(1,"Francisco","Ochoa Delgado",20, false);
            Perro _perro = new Perro(1,"Queso","Huski",1,18,2.05,"labar bien su pelo y cepillarlo constantemente","40 m2");
            Console.WriteLine("Ingrese la funcion que dese realizar");
            Console.WriteLine("1.-Adoptar");
            Console.WriteLine("2.-ver lista de personas");
            Console.WriteLine("3.-Ver lista de perros");
            Console.WriteLine("4.-Agregar cachorro ");
            Console.WriteLine();
            
            int caso = 1;
            caso = int.Parse(Console.ReadLine());
                switch (caso)
            {
                case 1:
                    if (_adoptador.Aprovado == true)
                    {
                        Console.WriteLine("El perro " + _perro.Nombre + " a sido adoptado por " + _adoptador.Nombre);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("El señor " + _adoptador.Nombre +" no puede adoptar al perro XD" );
                        Console.ReadLine();
                    }

                    break;
                case 2:
                    Console.WriteLine("Nombre " + _adoptador.Nombre);
                    Console.WriteLine("Apellidos: " +_adoptador.Apellidos);
                    Console.WriteLine("Edad: "+_adoptador.Edad);
                    Console.ReadLine();
                    
                        break;
                case 3:
                    Console.WriteLine("Nombre del perro: " + _perro.Nombre);
                    Console.WriteLine("edad: " + _perro.Edad);
                    Console.WriteLine("Raza: " + _perro.Raza);
                    Console.ReadLine();
                    break;
                default :
                    Console.WriteLine("Error elije una opcion del menu...");
                    Console.ReadLine();
                    return;
                    
            }
           
        }
    }

}
