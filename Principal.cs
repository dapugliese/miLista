using System;

namespace Libreria {
    class Programa {
        public static void Main(string[] args) {
            
            string elemento;
            char opcion;
            int Id;
            int contador = 0;

            List<string>  miLista = new List<string>();

            opcion = mostrarMenu();

            while ( opcion != '9' ){

                switch (opcion) {
                    case '1':  
                        Console.Write("Ingrese elemento: ");
                        elemento = Console.ReadLine();
                        miLista.Add(elemento);
                        Console.Clear();
                        break;

                    case '2':  
                        contador = 0; 
                        foreach( string elem  in  miLista ){
                            Console.Write(elem); 
                            Console.WriteLine(" ("+contador+")");
                            contador++;

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '3':
                        contador = 0;
                        Console.Write("Ingrese Id: "); 
                        Id =  Convert.ToInt16(Console.ReadLine()) ;

                        if (Id  >= 0 && Id < miLista.Count) {
                            Console.WriteLine(miLista[Id]);
                        }
                          else {
                                Console.WriteLine("No se encuentra elemento para Id: {0}",Id);

                          }
                            
                        

                        /*
                        foreach(var x in miLista){
                            if (contador == Id){
                                Console.WriteLine(x);
                            }
                            contador++;
                        }
                        */
                        Console.ReadKey();
                        break;

                    default:  
                            Console.Write("Opción incorrecta"); 
                            Console.ReadKey();
                            break;
                }
                opcion = mostrarMenu(); 
            }



            Console.WriteLine();

            
        }   

        public static char mostrarMenu(){

            char opcion;

            Console.Clear();
            Console.WriteLine("Menu de Opciones");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("1.- Agregar Elementos a la lista");
            Console.WriteLine("2.- Leer toda la lista");
            Console.WriteLine("3.- Leer elemento por Id");
            Console.WriteLine("9.- Salir del programa");

            Console.WriteLine();
            Console.Write("Ingrese opción: ");

            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();
            return opcion;

    }
    }


}