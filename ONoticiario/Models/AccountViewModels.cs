﻿using ONoticiario.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentitySample.Models
{
    

    public class LoginViewModel
    {
        [Required(ErrorMessage = "O {0} tem de conter um email.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")]
        [StringLength(100, ErrorMessage = "O {0} tem que ter {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "Palavra passe e sua confirmação não são iguais! ")]
        public string ConfirmPassword { get; set; }

        //atributos especificos do utilizador
        public Utilizadores Utilizador { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} tem que ter {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "Palavra passe e sua confirmação não são iguais! ")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}