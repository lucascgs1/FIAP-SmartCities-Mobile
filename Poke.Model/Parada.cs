using System;
using System.ComponentModel.DataAnnotations;

namespace Poke.Model
{
    public class Parada
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Local { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [Display(Name = "Latitude", Prompt = "Digite o {0}")]
        public string Latitude { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [Display(Name = "Longitude", Prompt = "Digite o {0}")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data Cadastro", Prompt = "Digite o {0}")]
        public DateTime? DataCadastro { get; set; }
    }
}