using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_.NET_MVC.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O Campo descrição é obrigatorio")]
        public string Descricao { get; set; }
        public List<Usuario> Produtos { get; set; }
    }
}
