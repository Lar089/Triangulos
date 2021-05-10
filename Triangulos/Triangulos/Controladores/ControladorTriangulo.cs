using System;
using System.Collections.Generic;
using System.Text;
using Triangulos.Dominio;

namespace Triangulos.Controladores
{
    class ControladorTriangulo
    {
        public string TipoDoTriangulo(int x, int y, int z)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.lado_x = x;
            triangulo.lado_y = y;
            triangulo.lado_z = z;

            string resultadoValidacao = triangulo.Validar();

            if (resultadoValidacao == "TRIANGULO_VALIDO")
            {
                if (triangulo.lado_x == triangulo.lado_y && triangulo.lado_y == triangulo.lado_z)
                    return ApresentarMensagem(TipoTriangulo.equilatero);

                if (triangulo.lado_x == triangulo.lado_y)
                    return ApresentarMensagem(TipoTriangulo.isosceles);

                if (triangulo.lado_x == triangulo.lado_z)
                    return ApresentarMensagem(TipoTriangulo.isosceles);

                if (triangulo.lado_y == triangulo.lado_z)
                    return ApresentarMensagem(TipoTriangulo.isosceles);

                if (triangulo.lado_x != triangulo.lado_y && triangulo.lado_x != triangulo.lado_z && triangulo.lado_y != triangulo.lado_z)
                    return ApresentarMensagem(TipoTriangulo.escaleno);
            }

            return resultadoValidacao;
        }

        private string ApresentarMensagem(TipoTriangulo tm)
        {
            string tipo = "";
            switch (tm)
            {
                case TipoTriangulo.equilatero:
                    tipo = "TRIÂNGULO EQUILÁTERO";
                    break;

                case TipoTriangulo.escaleno:
                    tipo = "TRIÂNGULO ESCALENO";
                    break;

                case TipoTriangulo.isosceles:
                    tipo = "TRIÂNGULO ISÓSCELES";
                    break;

                default:
                    break;
            }
            return tipo;
        }

    }
}
