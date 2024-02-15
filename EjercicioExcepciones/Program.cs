// See https://aka.ms/new-console-template for more information
using EjercicioExcepciones;
using System.Drawing;
internal class Programa
{
    private static void Main(string[] args)
    {
        Console.WriteLine("EjercicioExcepciones");

        Calcular calcular = new Calcular();
        calcular.Suma();
        calcular.Resta();

        int Menu() 
        {
            int opcion;
            Console.WriteLine("**********************");
            Console.WriteLine("*        Menu        *");
            Console.WriteLine("*    1.Suma          *");
            Console.WriteLine("*    2.Resta         *");
            Console.WriteLine("*    3.Divicion      *");
            Console.WriteLine("*    4.Multiplicacion*");
            Console.WriteLine("**********************");
            Console.WriteLine("***Escoja la Opcion***");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        void Suma() 
        {
            Console.WriteLine("******");
            Console.WriteLine("*Suma*");
            Console.WriteLine("Valor 1:");
            calcular.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            calcular.B = double.Parse(Console.ReadLine());
            Console.WriteLine($"El Resultado es: {calcular.Suma()}");
        }

        void Resta()
        {
            Console.WriteLine("******");
            Console.WriteLine("*Resta*");
            Console.WriteLine("Valor 1:");
            calcular.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            calcular.B = double.Parse(Console.ReadLine());
            Console.WriteLine($"El Resultado es: {calcular.Resta()}");
        }

        void Divicion()
        {
            Console.WriteLine("**********");
            Console.WriteLine("*Divicion*");
            Console.WriteLine("Valor 1:");
            calcular.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            calcular.B = double.Parse(Console.ReadLine());
            Console.WriteLine($"El Resultado es: {calcular.Resta()}");
        }

        void Multiplicacion()
        {
            Console.WriteLine("****************");
            Console.WriteLine("*Multiplicacion*");
            Console.WriteLine("Valor 1:");
            calcular.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            calcular.B = double.Parse(Console.ReadLine());
            Console.WriteLine($"El Resultado es: {calcular.Resta()}");
        }

        int opcion = Menu();
        do
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Divicion();
                    break;
                case 4:
                    Multiplicacion();
                    break;
                default:
                    Console.WriteLine("Opcion No Valida");
                    break;
            }

            opcion = Menu();

        }  while (opcion !=5);
    }
}