using bytebank_ADM.Comercial;
using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool ValidarLogin(IAutenticavel funcionario,string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuário Autenticado!");
                return usuarioAutenticado;
            }
            Console.WriteLine("Usuário ou senha incorretos!");
            return false;
        }


    }
}
