using EasyPack.Domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPack.Persistence.Contratos
{
    public interface IEntregaPersist
    {
        Task<Entrega[]> GetAllEntregasAsync(bool includeCarga = false);

        Task<Entrega> GetEntregaByIdAsync(int id, bool includeCarga = false);
    }
}
