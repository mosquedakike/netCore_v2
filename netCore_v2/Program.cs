using System;

namespace netCore_v2
{
    /*
     ********************************************************************************************************************
     * SOBRE CARGA DE METODOS, ES CUANDO TENEMOS MAS DE UN CONSTRUCTOR CON ELMISMO NOMBRE PERO CON PARAMETROS DIFERENTES*
     ******************************************************************************************************************** 
     */
    class Program
    {
        //Metodo constructor vacio
        public Program()
        {
            Console.WriteLine("This is a test with constructores");
        }

        //Metodo constructor con pametros
        public Program(string name)
        {
            Console.WriteLine(name);
        }

        public Program(string name, int age)
        {
            Console.WriteLine(name + age);
        }

        static void Main(string[] args)
        {
            var data = new Program();
            var data2 = new Program("kike");

            Console.WriteLine("Inserta un nombre: ");
            string a = Console.ReadLine();

            Console.WriteLine("Inserta un numero: ");
            int b = Convert.ToInt16(Console.ReadLine());

            new Program(a,b);
            
            Console.ReadLine();
        }
    }
}
