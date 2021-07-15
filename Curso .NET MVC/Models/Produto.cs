using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_.NET_MVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo Nome é obrigatorio")]
        [MinLength(3)]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Valor é obrigatorio")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "O Campo Ativo é obrigatorio")]
        public Boolean Ativo { get; set; }


        
    }
}
