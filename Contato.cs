﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContatos
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }

        public Contato (string nome =  "", string email = "", string numeroTelefone = "")
        {
            this.Nome = nome;
            this.Email = email;
            this.NumeroTelefone = numeroTelefone;
        }

    }

}
