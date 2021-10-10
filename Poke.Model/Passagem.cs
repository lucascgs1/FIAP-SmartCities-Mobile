using System;

namespace Poke.Model
{
    public class Passagem
    {
        public int Id { get; set; }

        public DateTime HorarioPartida { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public int UsuarioId { get; set; }

        public int ViagemId { get; set; }
    }
}