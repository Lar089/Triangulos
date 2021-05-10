using System;
using Triangulos.Controladores;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorTriangulo controlador = new ControladorTriangulo();
            Console.WriteLine("TRIÂNGULO: 2,3,3");
            string mensagemResultado1 = controlador.TipoDoTriangulo(2, 3, 3);
            Console.WriteLine($"{mensagemResultado1}");

            Console.WriteLine("TRIÂNGULO: 5,4,2");
            string mensagemResultado2 = controlador.TipoDoTriangulo(5, 4, 2);
            Console.WriteLine($"{mensagemResultado2}");

            Console.WriteLine("TRIÂNGULO: 3,3,3");
            string mensagemResultado3 = controlador.TipoDoTriangulo(3, 3, 3);
            Console.WriteLine($"{mensagemResultado3}");
        }
    }
}
