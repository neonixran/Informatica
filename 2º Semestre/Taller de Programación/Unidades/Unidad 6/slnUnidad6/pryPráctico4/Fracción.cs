using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPráctico4
{
    internal class Fracción
    {
        public int Numerador { get; set; }

        private int _denominador;
        public int Denominador
        {
            get { return _denominador; }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El denominador no puede ser cero");
                }

                _denominador = value;
            }
        }

        static Fracción Sumar(Fracción f1, Fracción f2)
        {
            Fracción resultado = new Fracción();
            resultado.Numerador = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador;
            resultado.Denominador = f1.Denominador * f2.Denominador;

            return resultado;
        }

        static Fracción Multiplicar(Fracción f1, Fracción f2)
        {
            Fracción resultado = new Fracción();
            resultado.Numerador = f1.Numerador * f2.Denominador;
            resultado.Denominador = f1.Denominador * f2.Denominador;

            return resultado;
        }
    }
}
