﻿using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        
        public abstract bool Autenticar(string login, string senha);

        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
