using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace Curso_.NET_MVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        //[Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo Nome é obrigatorio")]
        [MinLength(3)]
        [MaxLength(20)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Email é obrigatorio")]
        [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        //[Range(1,10, ErrorMessage ="Valor fora da faixa")]
        [Required(ErrorMessage = "O Campo Senha é obrigatorio")]
        [MinLength(8)]
        [MaxLength(20)]
        public string Senha { get; set; }
        
    
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
