using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos2Numeros.Modelo
{
    public class Controle
    {
        public String num1;
        public String num2;
        public String resultado;
        public String mensagem;

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.num1 = this.num1;
            validacao.num2 = this.num2;
            validacao.Validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.n1 = validacao.n1;
                calculos.n2 = validacao.n2;
                calculos.Somar();
                this.resultado = calculos.res.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

    }
}
