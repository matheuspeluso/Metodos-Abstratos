using System;

namespace ConsoleApp1.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int QtdFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual,int qtdFuncionarios) :base(nome,rendaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }

        public override double CalcImposto()
        {
            if (QtdFuncionarios <= 10)
            {
                return (RendaAnual * 16) / 100;
            }
            else
            {
                return (RendaAnual * 14) / 100;
            }
            
        }


    }
}
