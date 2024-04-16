using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
User
{
    internal class Program
{
    static int Dinero = 150;
    static int carritoDinero;
    public static List<string> Carrito = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {

            Console.Clear();
            Console.WriteLine("bienvenido a la tiendita de don Pepe");
            Console.WriteLine($"dinero : {Dinero}");
            Console.WriteLine("\n 1. Comprar \n 2. Carrito de compras \n 3. Agregar mas dinero \n 4. Salir de la pagina");
            int seguir = 0;
            string eleccion = Console.ReadLine();
            if (int.TryParse(eleccion, out seguir))
            {
                if (seguir == 1)
                {
                    while (seguir == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"dinero : {Dinero}");
                        Console.WriteLine("\n1. Pulsera \n2. Taza \n3. Funda  \n4. Muñeca  \n5. Ropa de Muñeca \n6. Volver");
                        int siguiendo = 0;
                        string compra = Console.ReadLine();
                        if (int.TryParse(compra, out siguiendo))
                        {
                            if (siguiendo == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"dinero : {Dinero}");
                                Producto producto = new Producto();
                                producto.ProductoDeTela("pulsera", 8, "Tela", "rojo", 35);
                                Console.WriteLine($"Nombre:{producto.Nombre}   Tamaño:{producto.Tamaño}cm   Material:{producto.Material}     Color:{producto.Color}    Precio:{producto.Precio}$");
                                Console.WriteLine("\n 1. Comprar \n 2. Volver");
                                string decicion = Console.ReadLine();
                                if (decicion == "1")
                                {
                                    if (Dinero > producto.Precio)
                                    {
                                        carritoDinero = carritoDinero + producto.Precio;
                                        Carrito.Add(producto.Nombre);
                                        Dinero = Dinero - producto.Precio;
                                        Console.WriteLine("Compra exitosa");
                                        Console.ReadKey();
                                        seguir = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay plata papito :(");
                                        Console.ReadKey();
                                    }


                                }
                                else
                                {
                                    seguir = 1;
                                }
                            }
                            if (siguiendo == 2)
                            {
                                Console.Clear();
                                Console.WriteLine($"dinero : {Dinero}");
                                Producto producto = new Producto();
                                producto.ProductoDeArcilla("Taza", 300, "Arcilla", "Plomo", 63);
                                Console.WriteLine($"Nombre:{producto.Nombre}   Peso:{producto.Peso}g   Material:{producto.Material}     Color:{producto.Color}    Precio:{producto.Precio}$");
                                Console.WriteLine("\n 1. Comprar \n 2. Volver");
                                string decicion = Console.ReadLine();
                                if (decicion == "1")
                                {
                                    if (Dinero > producto.Precio)
                                    {
                                        carritoDinero = carritoDinero + producto.Precio;
                                        Carrito.Add(producto.Nombre);
                                        Dinero = Dinero - producto.Precio;
                                        Console.WriteLine("Compra exitosa");
                                        Console.ReadKey();
                                        seguir = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay plata papito :(");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    seguir = 1;
                                }
                            }
                            if (siguiendo == 3)
                            {
                                Console.Clear();
                                Console.WriteLine($"dinero : {Dinero}");
                                Producto producto = new Producto();
                                producto.ProductoDeTela("Funda", 15, "Tela", "celeste", 45);
                                Console.WriteLine($"Nombre:{producto.Nombre}   Tamaño:{producto.Tamaño}cm   Material:{producto.Material}     Color:{producto.Color}    Precio:{producto.Precio}$");
                                Console.WriteLine("\n 1. Comprar \n 2. Volver");
                                string decicion = Console.ReadLine();
                                if (decicion == "1")
                                {
                                    if (Dinero > producto.Precio)
                                    {
                                        carritoDinero = carritoDinero + producto.Precio;
                                        Carrito.Add(producto.Nombre);
                                        Dinero = Dinero - producto.Precio;
                                        Console.WriteLine("Compra exitosa");
                                        Console.ReadKey();
                                        seguir = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay plata papito :(");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    seguir = 1;
                                }
                            }
                            if (siguiendo == 4)
                            {
                                Console.Clear();
                                Console.WriteLine($"dinero : {Dinero}");
                                Producto producto = new Producto();
                                producto.ProductoDeArcilla("Muñeca", 590, "Arcilla", "blanco", 98);
                                Console.WriteLine($"Nombre:{producto.Nombre}   Peso:{producto.Peso}g   Material:{producto.Material}     Color:{producto.Color}    Precio:{producto.Precio}$");
                                Console.WriteLine("\n 1. Comprar \n 2. Volver");
                                string decicion = Console.ReadLine();
                                if (decicion == "1")
                                {
                                    if (Dinero > producto.Precio)
                                    {
                                        carritoDinero = carritoDinero + producto.Precio;
                                        Carrito.Add(producto.Nombre);
                                        Dinero = Dinero - producto.Precio;
                                        Console.WriteLine("Compra exitosa");
                                        Console.ReadKey();
                                        seguir = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay plata papito :(");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    seguir = 1;
                                }
                            }
                            if (siguiendo == 5)
                            {
                                Console.Clear();
                                Console.WriteLine($"dinero : {Dinero}");
                                Producto producto = new Producto();
                                producto.ProductoDeTela(" Ropa de Muñeca", 45, "Tela", "Amarillo y Rosa", 115);
                                Console.WriteLine($"Nombre:{producto.Nombre}   Tamaño:{producto.Tamaño}cm   Material:{producto.Material}     Color:{producto.Color}    Precio:{producto.Precio}$");
                                Console.WriteLine("\n 1. Comprar \n 2. Volver");
                                string decicion = Console.ReadLine();
                                if (decicion == "1")
                                {
                                    if (Dinero > producto.Precio)
                                    {
                                        carritoDinero = carritoDinero + producto.Precio;
                                        Carrito.Add(producto.Nombre);
                                        Dinero = Dinero - producto.Precio;
                                        Console.WriteLine("Compra exitosa");
                                        Console.ReadKey();
                                        seguir = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay plata papito :(");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    seguir = 1;
                                }
                            }
                            if (siguiendo == 6)
                            {
                                seguir = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Solo se permiten numeros >:(");
                        }
                    }
                }
                if (seguir == 2)
                {
                    if (Carrito.Count == 0)
                    {
                        Console.WriteLine("no hay nada en el carrito");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var item in Carrito)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"Suma de los productos: {carritoDinero}");
                        Console.ReadKey();
                    }

                }
                if (seguir == 3)
                {
                    Dinero = Dinero + 150;
                    Console.WriteLine("tienes 150 mas de dinero");
                    Console.ReadKey();
                }
                if (seguir == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ponga los numeros indicados >:(");
                }
            }
            else
            {
                {
                    Console.WriteLine("Solo se permiten numeros >:(");
                }
            }
        }
    }
}
}
