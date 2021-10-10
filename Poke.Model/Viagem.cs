using System;
using System.ComponentModel.DataAnnotations;

namespace Poke.Model
{
    public class Viagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data da viagem", Prompt = "Digite o {0}")]
        public DateTime? DataViagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Destino", Prompt = "Digite o {0}")]
        public string Destino { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Origem", Prompt = "Digite o {0}")]
        public string Origem { get; set; }

        public int? VeiculoId { get; set; }

        public int RotaId { get; set; }
    }
}