using System;

namespace EasyPack.Domain.model
{
    public class Carga
    {
        public Carga()
        {

        }

        public int Id { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Comprimento { get; set; }
        public double Largura { get; set; }
        public DateTime Data_Entrega { get; set; }
        public int EntregaId { get; set; }
        public Entrega Entrega { get; set; }


    }
}