﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStoreEnterprise.Identidade.API.Models
{
    public class UserViewModels
    {
    }

    public class UsuarioRegistro
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage = "As Senhas não conferem")]
        public string SenhaConfirmacao { get; set; }
    }

    public class UsuarioLogin
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }

    }
}
