﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONoticiario.Models
{
    public class Comentarios
    {

        //construtor da class comentarios
        public Comentarios()
        {

        }

        //ID
        [Key]
        public int ID { get; set; }

        //Atributos da class comentarios
        [RegularExpression("^[a-zA-Z0-9_.,áãàâÃÀÁÂÔÒÓÕòóôõÉÈÊéèêíìîÌÍÎúùûçÇ!-.? ]*", ErrorMessage = "O {0} tem caracteres inválidos!")]
        public string Descricao { get; set; }

        //Forasteira
        [ForeignKey("Utilizador")]
        public int UtilizadorFK { get; set; }
        public virtual Utilizadores Utilizador { get; set; }

        //hora do comentário
        public DateTime Data { get; set; }

        //foreign key Noticias
        [ForeignKey("Noticia")]
        public int NoticiasFK { get; set; }
        public virtual Noticias Noticia { get; set; }
    }
}