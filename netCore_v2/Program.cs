using System;

namespace netCore_v2
{
    class Program
    {
        private String name;
        static void Main()
        {
            var data = new Program();
            var retornar = data.retornaIntToString();
            
            
            data.metodoPrivado();
            data.metodoPublico();
            data.retortoString();

            Console.WriteLine(data.retortoString());
            Console.WriteLine(retornar);

            Console.ReadLine();
        }

        //DECLARANDO METODOS PRIVADOS | NO RETORNA VALORES
        private void metodoPrivado()
        {
            Console.WriteLine("Hola desde un metodo private!");
        }

        //DECLARANDO METODOS PUBLICOS | NO RETORNA VALORES
        public void metodoPublico()
        {
            Console.WriteLine("Hola desde un metodo public!");
        }

        //DECLARANDO METODOS PRIVADOS | SI RETORNA VALORES | TIPO STRING
        private string retortoString()
        {
            return "Soy una cadena con return";
        }

        //DECLARANDO METODOS PRIVADOS | SI RETORNA VALORES | TIPO INT TO STRING
        private int retornaIntToString()
        {
            return Convert.ToInt16("16");
        }
        
    }
}
