using System;

namespace netCore_v2
{
    class Program
    {
        private string cadena; 
        private string verMayusculas = "";
        private string verMinusculas = "";
        private int n; 
        private string[] Mayusculas; 
        private string[] Minusculas; 
        private string[] tempMy; 
        private string[] tempMn; 

        public Program(string cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMy = new string[n];
            tempMn = new string[n];
        }

        private string mayusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //[IsUpper] sirve para identificar las letras mayusculas
                if (Char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]);
                }
            }

            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null)
                {
                    Mayusculas[i] = tempMy[i];
                    //verMayusculas = verMayusculas + "," + verMayusculas[i];
                    verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
                }
            }
            return verMayusculas;
        }

        private string minusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //[IsUpper] sirve para identificar las letras minusculas
                if (Char.IsLower(cadena[i]))
                {
                    tempMn[i] = Convert.ToString(cadena[i]);
                }
            }

            for (int i = 0; i < tempMn.Length; i++)
            {
                if (tempMn[i] != null)
                {
                    Minusculas[i] = tempMn[i];
                    //verMayusculas = verMayusculas + "," + verMayusculas[i];
                    verMinusculas = $"{verMinusculas},{Minusculas[i]}";
                }
            }
            return verMinusculas;
        }

        static void Main(string[] args)
        {
            var cadena = Console.ReadLine();
            var data = new Program(cadena);
            Console.WriteLine("Las letras mayusculas son: " + data.mayusculas() + "\n\n" + "Las letras minusculas son: " + data.minusculas());

            Console.ReadLine();
        }
    }
}
