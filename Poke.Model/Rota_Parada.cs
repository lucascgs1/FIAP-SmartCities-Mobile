using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poke.Model
{
    public class Rota_Parada
    {
        [Key]
        [Column(Order = 1)]
        public int RotaId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ParadaId { get; set; }
    }
}