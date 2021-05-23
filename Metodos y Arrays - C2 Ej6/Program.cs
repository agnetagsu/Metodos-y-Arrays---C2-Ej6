using System;

namespace Metodos_y_Arrays___C2_Ej6
{
    class Cifras
    {
        public int calculanumcifras(int numero)
        {
            int resultado = numero;
            int cociente = numero;
            int suscifras = 0;
            Boolean fin = false;

            do
            {
                resultado = cociente / 10;
               
                if (resultado != 0)
                {
                    suscifras++;
                }
                else
                {
                    fin = true;
                }
                
                cociente = resultado;
            }
            while (!fin);
            suscifras++;
            return suscifras;

        }
        static void Main(string[] args)
        {
            int numero;
            Cifras numcifras = new Cifras();
            Console.WriteLine("Introduce un numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numcifras.calculanumcifras(numero));

        }
    }
}
