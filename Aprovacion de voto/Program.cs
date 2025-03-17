using System;
namespace Aprovacion_de_voto
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Estimado/a ingrese su nombre y apellido:");
            Console.ReadLine();
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usted puede votar");


            }

            else
            {
                Console.WriteLine("Usted no puede votar");
            }
            
                 



        }
    }
}