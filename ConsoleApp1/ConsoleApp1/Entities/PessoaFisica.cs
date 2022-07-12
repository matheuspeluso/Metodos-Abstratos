using System;

namespace ConsoleApp1.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual,double gastoSaude) :base(nome,rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalcImposto()
        {
            double imposto = 0.0;
            double reducao = 0.0;
            if (RendaAnual <= 20000)
            {
                imposto = (RendaAnual * 15) / 100;
                if(GastoSaude > 0)
                {
                    reducao = (GastoSaude * 50) / 100;
                    imposto -= reducao; 
                }
                return imposto;
            }
            else
            {
                imposto =  (RendaAnual * 25) / 100;
                if (GastoSaude > 0)
                {
                    reducao = (GastoSaude * 50) / 100;
                    imposto -= reducao;
                }
                return imposto;
            }
        }
    }
}
