using EasyPack.Domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPack.Persistence.Contratos
{
    public interface ICargaPersist
    {
        Task<Carga[]> GetAllCargaAsync(bool includeEntrega = false);

        Task<Carga> GetCargaByIdAsync(int id, bool includeEntrega = false);
    }
}
