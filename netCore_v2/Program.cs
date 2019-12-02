using System;

namespace netCore_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //static
            var data = new Variable_estatica();
            Variable_estatica.velocidad = 3.0;
            var data1 = new Variable_estatica();
            Console.WriteLine("Velocidad de data = " + Variable_estatica.velocidad + "\n" + "Velocidad de data1 = " + Variable_estatica.velocidad);

            //no static
            var data2 = new variable_no_estatica();
            data2.velocidad2 = 5.0;
            var data3 = new variable_no_estatica();
            Console.WriteLine("velocidad de data2 = {0}\nvelocidad de data3 = {1}", data2.velocidad2, data3.velocidad2);
        }

        class Variable_estatica
        {
            public static double velocidad;
        }

        class variable_no_estatica
        {
            public double velocidad2;
        }
    }
}
