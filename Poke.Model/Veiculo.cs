using System.ComponentModel.DataAnnotations;

namespace Poke.Model
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Placa", Prompt = "Digite o {0}")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Quantidade de assentos", Prompt = "Digite o {0}")]
        public string QtdAssentos { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Ano", Prompt = "Digite o {0}")]
        public string Ano { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Tipo de veiculo", Prompt = "Digite o {0}")]
        public string TipoVeiculo { get; set; }

        public bool? Wifi { get; set; }

        public bool? Banheiro { get; set; }

        public bool? Lanches { get; set; }

        public bool? ArCondicionado { get; set; }
    }
}