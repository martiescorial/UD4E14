using System;

namespace UD4E14
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Introduce area del circulo";
            
            double radio = Convert.ToDouble(texto);

            //Formula area circulo, usamos algunos de los metodos de Math
            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El area del circulo es " + area);
        }
    }
}
