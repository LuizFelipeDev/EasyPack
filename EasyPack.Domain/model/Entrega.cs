using System;
using System.Collections.Generic;

namespace EasyPack.Domain.model
{
    public class Entrega
    {
        public Entrega(){}

        
        public int Id { get; set; }

        public DateTime Data_Coleta { get; set;}

        public IEnumerable<Carga> Cargas { get; set; }
    }
}