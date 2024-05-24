using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Esfera : Figura
    {
        public Esfera(float lado1)
        {//radio se va a leer de la caja de texto
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea dispinible para la clase rectangulo cuando no se use rectangulo la varible sera ==
        }
        public override float area()
        {
            return 4*3.1416F*Lado1*Lado1;
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            return (4*3.1416F*(Lado1 * Lado1*Lado1))/3;
        }
    }
}
