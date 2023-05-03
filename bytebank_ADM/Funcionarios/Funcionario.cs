using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario( string nome, string cpf, double salario)
        {  
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();



        public string Cpf { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

       

    }
}
