using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EXAMEN_POO
{
    //Clase
    class Inventario
    {
        //Campos de la clase
        public string NProducto;
        public string Descripcion;
        public float Precio;
        public int CStock;

        //Constructor de la clase
        public Inventario(string NProducto,string Descripcion,float Precio,int CStock)
        {
            this.NProducto = NProducto;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.CStock = CStock;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n***SISTEMA-DE-INVENTARIO-AMAZON***");
                Console.WriteLine("1.-Creacion de Inventario.");
                Console.WriteLine("2.-Consultar Inventario.");
                Console.WriteLine("3.-Salir.");
                Console.Write("\nQue Opcion Deseas: ");
                Opcion = Int32.Parse(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        
                        try
                        {
                            StreamWriter sw = new StreamWriter("Productos.txt", true);
                            Console.WriteLine("Escribiendo. . .\n");

                            //Declaracion de Variables
                            string NProducto;
                            string Descripcion;
                            float Precio;
                            int CStock;

                            //Asigancion de valor a las variables
                            Console.Write("Ingrese Nombre del Producto: ");
                            NProducto=Console.ReadLine();
                            Console.Write("Ingrese Descripcion del Producto: ");
                            Descripcion = Console.ReadLine();
                            Console.Write("Ingrese Precio del Producto: ");
                            Precio=Single.Parse(Console.ReadLine());
                            Console.Write("Ingrese Cantidad en Stock: ");
                            CStock = Int32.Parse(Console.ReadLine());

                            //Creacion del objeto
                            Inventario Product = new Inventario(NProducto,Descripcion,Precio,CStock);

                            //Escribir
                            sw.WriteLine("Nombre: " + Product.NProducto);
                            sw.WriteLine("Descripcion: " + Product.Descripcion);
                            sw.WriteLine("Precio: {0:C}" + Product.Precio);
                            sw.WriteLine("Stock: " + Product.CStock);

                            //Limpiar consola
                            Console.ReadKey();
                            Console.Clear();

                            

                        }
                        catch(OverflowException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Presione <Enter> Para Continuar. . .");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Presione <Enter> Para Continuar. . .");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Presione <Enter> Para Continuar. . .");
                            Console.ReadKey();
                            Console.Clear();
                        }
                       
                            Console.WriteLine("Escritura Realizada\n");
                            Console.WriteLine("Presione <Enter> Para Finalizar. . .");
                            Console.ReadKey();
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Leyendo Archivo. . .");
                            StreamReader sw = new StreamReader("Productos.txt");
                            
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("El Archivo no se pudo leer");
                            Console.WriteLine(e.Message);

                        }
                        Console.WriteLine("Presione <Enter> Para Finalizar. . .");
                        Console.ReadKey();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("\nPresione <enter> para Salir del Programa.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("\nEsa Opción No Existe!!, Presione < enter > para Continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (Opcion!=3);
        }
    }
}
