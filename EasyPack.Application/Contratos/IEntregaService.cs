using EasyPack.Domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPack.Application.Contratos
{
    public interface IEntregaService
    {
        Task<Entrega> AddEntrega(Entrega model);
        Task<Entrega> UpdateEntrega(int id, Entrega model);
        Task<bool> DeleteEntrega(int EntregaId);
        Task<Entrega[]> GetAllEntregaAsync(bool includeCarga = false);
        Task<Entrega> GetEntregaByIdAsync(int id, bool includeCarga = false);
    }
}
