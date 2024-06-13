using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class PoligonoIrreg : Figura
    {
        public PoligonoIrreg(float lado1) { Lado1 = lado1; }
        public override float area()
        {
            throw new NotImplementedException();
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            throw new NotSupportedException();
        }
    }
    class Rombo : PoligonoIrreg
    {
        private float diagmay;
        private float diagmen;
        public float Diagmay
        {
            set
            {
                if (value < 0)
                {
                    diagmay = 0;
                }
                else
                {
                    diagmay = value;
                }
            }
            get
            {
                return diagmay;
            }
        }
        public float Diagmen
        {
            set
            {
                if (value < 0)
                {
                    diagmen = 0;
                }
                else
                {
                    diagmen = value;
                }
            }
            get
            {
                return diagmen;
            }
        }
        public Rombo(float lado1, float diagmay, float diagmen) : base(lado1)
        {
            this.diagmay = diagmay;
            this.diagmen = diagmen;
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return (Diagmay + Diagmen) / 2;
        }
        public override float perimetro()
        {
            return 4 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
    class Trapecio : PoligonoIrreg
    {
        private float base1;
        private float base2;
        private float altura;


        public Trapecio(float lado1, float base1, float base2, float altura) : base(lado1)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.altura = altura;
        }
        public float Base1
        {
            set
            {
                if (value < 0)
                {
                    base1 = 0;
                }
                else
                {
                    base1 = value;
                }
            }
            get
            {
                return base1;
            }
        }
        public float Base2
        {
            set
            {
                if (value < 0)
                {
                    base2 = 0;
                }
                else
                {
                    base2 = value;
                }
            }
            get
            {
                return base2;
            }
        }
        public float Altura
        {
            set
            {
                if (value < 0)
                {
                    altura = 0;
                }
                else
                {
                    altura = value;
                }
            }
            get
            {
                return altura;
            }
        }
        public override float area()
        {
            return ((Base1 + Base2) * Altura) / 2;
        }
        public override float perimetro()
        {
            return 2 * Lado1 + Base1 + Base2;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
    class Paralelogramo : PoligonoIrreg
    {
        private float base1;
        private float altura;
        public float Base1
        {
            set
            {
                if (value < 0)
                {
                    base1 = 0;
                }
                else
                {
                    base1 = value;
                }
            }
            get
            {
                return base1;
            }
        }
        public float Altura
        {
            set
            {
                if (value < 0)
                {
                    altura = 0;
                }
                else
                {
                    altura = value;
                }
            }
            get
            {
                return altura;
            }
        }
        public Paralelogramo(float lado1, float base1, float altura) : base (lado1)
        {
            this.Base1 = base1;
            this.Altura = altura;
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return Base1 * Altura;
        }
        public override float perimetro()
        {
            return 2 * (Lado1 + Base1);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
