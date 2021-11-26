using EasyPack.Domain.model;
using EasyPack.Persistence.Contexto;
using EasyPack.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPack.Persistence
{
    public class CargaPersist : ICargaPersist
    {

        private readonly EasyPackContext _context;
        public CargaPersist(EasyPackContext context)
        {
            _context = context;
        }

        public async Task<Carga[]> GetAllCargaAsync(bool includeEntrega = false)
        {
            IQueryable<Carga> query = _context.Cargas;

            if (includeEntrega)
            {
                query = query.Include(c => c.Entrega);
            }

            query = query.OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Carga> GetCargaByIdAsync(int id, bool includeEntrega = false)
        {
            IQueryable<Carga> query = _context.Cargas;

            if (includeEntrega)
            {
                query = query.Include(c => c.Data_Entrega);
            }

            

            return await query.FirstOrDefaultAsync();
        }
    }
}
