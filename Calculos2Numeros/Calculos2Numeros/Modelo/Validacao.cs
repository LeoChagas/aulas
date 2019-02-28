using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos2Numeros.Modelo
{
    public class Validacao
    {
        public String num1;
        public String num2;
        public Double n1;
        public Double n2;
        public String mensagem ;
        
        public void Validar()
        {
            mensagem = "";
            try
            {
                this.n1 = Convert.ToDouble(this.num1);
                this.n2 = Convert.ToDouble(this.num2);
            }
            catch (FormatException)
            {

                mensagem = "Numero Invalido";
            }
        }

    }
}
