using System;

namespace Poke.Model
{
    public class Rota
    {
        public int Id { get; set; }

        public string Embarque { get; set; }

        public string Destino { get; set; }

        public decimal? Preco { get; set; }

        public int? TempoViagem { get; set; }

        public DateTime? HoraEmbarque { get; set; }

        public DateTime? HoraChegada { get; set; }

        public int? QtdParada { get; set; }
    }
}