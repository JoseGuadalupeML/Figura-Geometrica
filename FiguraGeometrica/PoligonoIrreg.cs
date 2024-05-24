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
        public Rombo(float lado1, float diagmay, float diagmen)
        {
            this.diagmay = diagmay;
            this.diagmen = diagmen;
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return (Diagmay + Diagmen)/2;
        }
        public override float perimetro()
        {
            return 4 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
        class trapecio : PoligonoIrreg
        {
            private float base1;
            private float base2;
            private float altura;
        }
        public float Base1
        {
            set
            {
                if (value < 0)
                {
                    Base1 = 0;
                }
                else
                {
                    Base1 = value;
                }
            }
            get
            {
                return Base1;
            }
        }
        public float Base2
        {
            set
            {
                if (value < 0)
                {
                    Base2 = 0;
                }
                else
                {
                    Base2 = value;
                }
            }
            get
            {
                return Base2;
            }
        }
        public float Altura
        {
            set
            {
                if (value < 0)
                {
                    Altura = 0;
                }
                else
                {
                    Altura = value;
                }
            }
            get
            {
                return Altura;
            }
        }
        public trapecio(float lado1, float base1, float base2, float altura)
        {
            this.Lado1 = lado1;
            this.Altura = altura;
            this.Base1 = base1;
            this.Base2 = base2;
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

        class Paralegramo : PoligonoIrreg
        {
            private float bas1;
            private float altu;
        }
        public float Bas1
        {
            set
            {
                if (value < 0)
                {
                    Bas1 = 0;
                }
                else
                {
                    Bas1 = value;
                }
            }
            get
            {
                return Bas1;
            }
        }
        public float Altu
        {
            set
            {
                if (value < 0)
                {
                    Altu = 0;
                }
                else
                {
                    Altu = value;
                }
            }
            get
            {
                return Altu;
            }
        }
        public Paralegramo(float lado1, float bas1, float altu)
        {
            this.Lado1 = lado1;
            this.Altu = altu;
            this.Bas1 = bas1;
        }
        public override float area()
        {
            return Bas1 * Altura;
        }
        public override float perimetro()
        {
            return 2 * (Lado1 + Bas1);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
