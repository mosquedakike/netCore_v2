using System;

namespace netCore_v2
{
    class Program
    {
        static void Main(string[] args)
        {

            Object[] parametros = { "kike", 25, 10, "Gran desarrollador", true, 25.2 };
            new Program().metodo(parametros);

            Object[] objeto_parametros = { };
            new Program().metodo_parametros("parametros nuevos", 2);

            int dataIn = 100;
            new Program().metodoIn(in dataIn);
            Console.WriteLine("Contenido de la variable dataIn: {0}", dataIn);

            int dataRef = 200;
            new Program().metodoRef(ref dataRef);
            Console.WriteLine("Contenido de la variable dataRef: {0}", dataRef);

            int dataOut;
            new Program().metodoOut(out dataOut);
            Console.WriteLine("Contenido de la variable dataOut: {0}", dataOut);
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

        //La palabra [in] agrega restricciones al valor de una variable para que no pueda ser modificada
        private void metodoIn(in int valor1)
        {
            //valor = 40; --si esta linea se descomenta marcaria un error por la [in]
            Console.WriteLine("Contenido de la variable valor1: {0}", valor1);
        }

        //La parabra [ref] si te permite modificar el valor de la variable pero con la condicion de que debe ser incialzida
        private void metodoRef(ref int valor2)
        {
            valor2 = 500 + 200;
        }
        
        //La palabra reservada [out] es la combianacion de [in] y [ref] porque te permite asignar datos nuevos a la variable
        //y puede ser declarada sin previa inicializacion
        private void metodoOut(out int valor3)
        {
            valor3 = 500 + 300;
        }
    }
}