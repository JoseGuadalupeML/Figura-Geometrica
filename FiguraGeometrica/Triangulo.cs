using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Triangulo : Figura
    {
        private float BaseT;
        public float baseT
        {
            //Modificador para poner el valor en la caja de memoria

            set //poner valor
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    baseT = 0; //manda el valor a 0
                } //No existen lados negativos
                else
                {
                    baseT = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return baseT; //regresa o cacha el valor de la variable lado1
            }
        }
        public Triangulo(float lado1,float BaseT)
        {//radio se va a leer de la caja de texto
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea dispinible para la clase rectangulo cuando no se use rectangulo la varible sera ==
            this.BaseT = BaseT;
        }
        public override float area()
        {
            return (BaseT * Lado1)/2;
        }
        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
