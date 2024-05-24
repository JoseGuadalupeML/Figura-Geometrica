using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Rectangulo : Figura
    {
        //esta clase reguiere 2 lados para funcionar
        //cremos el lado2
        private float lado2;
        public float Lado2
        {
            //Modificador para poner el valor en la caja de memoria

            set //poner valor
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a 0
                } //No existen lados negativos
                else
                {
                    lado2 = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado1
            }
        }
        //usamos su constructor de la clase padre 
        public Rectangulo(float lado1, float lado2)
        {//radio se va a leer de la caja de texto
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea dispinible para la clase rectangulo cuando no se use rectangulo la varible sera ==
            this.Lado2 = lado2;
        }
        /* vamos a usar los metodos de la clase padre
         * vamos a sobreescribir el comportamiento de estos
         */
        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
