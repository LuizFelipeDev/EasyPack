using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyPack.Domain.model;
using EasyPack.Persistence.Contexto;
using EasyPack.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace EasyPack.Persistence
{
    public class EntregaPersist : IEntregaPersist
    {
        private readonly EasyPackContext _context;

        public EntregaPersist(EasyPackContext context)
        {
            _context = context;
        }

        public async Task<Entrega[]> GetAllEntregasAsync(bool includeCarga)
        {
            IQueryable<Entrega> query = _context.Entregas;

            if (includeCarga)
            {
                query = query.Include(e => e.Cargas);
            }

            return await query.AsNoTracking().ToArrayAsync();
        }

        public async Task<Entrega> GetEntregaByIdAsync(int id, bool includeCarga)
        {
            IQueryable<Entrega> query = _context.Entregas.Where(e => e.Id == id);

            if (includeCarga)
            {
                query = query.Include(e => e.Cargas);
            }
            return await query.AsNoTracking().FirstOrDefaultAsync();
        }
    }
}
