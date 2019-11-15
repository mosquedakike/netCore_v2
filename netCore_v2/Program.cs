using System;

namespace netCore_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int data;
            String nombre;
            //new Program().metodo(out data);
            mensaje();
            Console.WriteLine(nombre);
            void mensaje() => nombre = "Luis Enrique Hernandez Mosqueda";
        }
            private void metodo(out int valor)
            {
                valor = funcion();
                //EXPRESION LANDA =>
                static int funcion() => 50 + 20;

            }
        }
    }

