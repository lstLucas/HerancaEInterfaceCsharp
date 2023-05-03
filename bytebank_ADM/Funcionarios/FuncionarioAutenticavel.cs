using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login);
        }
    }
}
