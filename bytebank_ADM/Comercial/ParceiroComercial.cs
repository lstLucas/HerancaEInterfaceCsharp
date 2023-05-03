﻿using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Comercial
{
    public class ParceiroComercial:IAutenticavel
    {
        public bool Autenticar(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login);
        }

        public string Login { get; set; }

        public string Senha { get; set; }
    }
}
