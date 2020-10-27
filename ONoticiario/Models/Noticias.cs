using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONoticiario.Models
{
    public class Noticias
    {
        public Noticias()
        {
            this.ListaComentarios = new HashSet<Comentarios>();
          
            this.ListaCategorias = new HashSet<Categorias>();
        }

        //Primary Key
        [Key]
        public int ID { get; set; }


        //Atributos da class Noticias
        //Data em fortmato yyyyMMdd
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        //Titulo de uma Noticia
        [RegularExpression("^[a-zA-Z0-9_.,áãàâÃÀÁÂÔÒÓÕòóôõÉÈÊéèêíìîÌÍÎúùûçÇ!-.? ]*",ErrorMessage ="O {0} tem caracteres inválidos!")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [Display(Name = "Título da Noticia")]
        public string Titulo { get; set; }

        //Capa da Noticia
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Capa { get; set; }



        //Chave forasteira
        [ForeignKey("Utilizador")]
        public int UtilizadorFK { get; set; }
        public virtual Utilizadores Utilizador { get; set; }

        //Paragrafo a negrito da Noticia
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [Display(Name = "Subtítulo")]
        public string Descricao { get; set; }

        //Conteudo da Noticia
        [Display(Name = "Conteúdo")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Conteudo { get; set; }





        //Relacionar a noticia aos varios comentarios
        public virtual ICollection<Comentarios> ListaComentarios { get; set; }

        //Relacionar a noticia às varias categorias
        public virtual ICollection<Categorias> ListaCategorias { get; set; }
    }
}