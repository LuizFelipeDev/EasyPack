using EasyPack.Domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPack.Application.Contratos
{
    public interface ICargaService
    {
        Task<Carga> AddCarga(Carga model);
        Task<Carga> UpdateCarga(int id, Carga model);
        Task<bool> DeleteCarga(int CargaId);
        Task<Carga[]> GetAllCargaAsync(bool includeEntrega = false);
        Task<Carga> GetCargaByIdAsync(int id, bool includeEntrega = false);

    }
}
