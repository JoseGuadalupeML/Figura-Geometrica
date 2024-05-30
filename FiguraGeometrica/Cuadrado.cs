using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cuadrado : Figura
    {
        public Cuadrado(float lado)
        {//radio se va a leer de la caja de texto
            //usando el boton guardar
            Lado1=lado; //hace que unicamente el valor la cantidad del lado sea dispinible para la clase rectangulo cuando no se use rectangulo la varible sera ==
        }
        public override float area()
        {
            return Lado1 * Lado1;
        }

        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1 + Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
