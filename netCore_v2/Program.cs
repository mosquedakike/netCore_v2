using System;

namespace netCore_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] parametros = {"kike", 25, 10, "Gran desarrollador", true, 25.2 };
            new Program().metodo(parametros);

            Object[] objeto_parametros = { };
            new Program().metodo_parametros("parametros nuevos",2);
           

            int number = 30;
            new Program().metodo_parametros(number);
        }

        //SI NECESITAMOS PASAR VARIOS PARAMETROS A UN METODO, TENEMOS LA OPCION DE HACERLO CON UN ARRAYS
        private void metodo(object[] parametros)
        {
            String nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            String puesto = (string)parametros[3];
            Console.WriteLine(nombre + " " + edad + " " + puesto);
        }

        //La palabra [params] sirve para tomar los parametros del objeto que esta llamando al metodo como en la linea 13
        private void metodo_parametros(params object[] objeto_parametros)
        {
            String mensaje = (string)objeto_parametros[0];
            int numero = (int)objeto_parametros[1];
            Console.WriteLine(mensaje + "\n" + numero);
        }

        //Con la palabra [in] agregas restricciones al valor de una variable para que no pueda ser modificada
        private void metodo_parametros(in int valor)
        {
            //valor = 40;
            Console.WriteLine(valor);
        }
    }
}