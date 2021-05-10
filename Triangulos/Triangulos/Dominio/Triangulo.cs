using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos.Dominio
{
    class Triangulo
    {
        public int lado_x;
        public int lado_y;
        public int lado_z;

        public string Validar()
        {
            string resultadoValidacao = "";

            if (lado_x == 0)
                resultadoValidacao += "O campo lado x é obrigatório, não pode ser zero \n";

            if (lado_y == 0)
                resultadoValidacao += "O campo lado y é obrigatório, não pode ser zero \n";

            if (lado_z == 0)
                resultadoValidacao += "O campo lado z é obrigatório, não pode ser zero \n";

            if (lado_x > (lado_y + lado_z))
                resultadoValidacao += "O campo x precisa ser menor que a soma dos lados y e z \n";

            if (lado_y > (lado_x + lado_z))
                resultadoValidacao += "O campo y precisa ser menor que a soma dos lados x e z \n";

            if (lado_z > (lado_x + lado_y))
                resultadoValidacao += "O campo z precisa ser menor que a soma dos lados x e y \n";

            if (string.IsNullOrEmpty(resultadoValidacao))
                resultadoValidacao = "TRIANGULO_VALIDO";

            return resultadoValidacao;
        }

    }
}
