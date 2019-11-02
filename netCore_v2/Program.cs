using System;

namespace netCore_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] parametros = {"kike", 25, 10, "Gran desarrollador", true, 25.2 };
            new Program().metodo(parametros);
            Console.ReadLine();    
        }

        //SI NECESITAMOS PASAR VARIOS PARAMETROS A UN METODO, TENEMOS LA OPCION DE HACERLO CON UN ARRAYS
        private void metodo(object[] parametros)
        {
            String nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            String puesto = (string)parametros[3];
            Console.WriteLine(nombre + " " + edad + " " + puesto);
        }
    }
}
