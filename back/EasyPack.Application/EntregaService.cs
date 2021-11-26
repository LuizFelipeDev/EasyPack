using EasyPack.Application.Contratos;
using EasyPack.Domain.model;
using EasyPack.Persistence.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPack.Application
{
    public class EntregaService : IEntregaService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly IEntregaPersist _entregaPersist;

        public EntregaService(IGeralPersist geralPersist, IEntregaPersist entregaPersist)
        {
            _geralPersist = geralPersist;
            _entregaPersist = entregaPersist;
        }

        public async Task<Entrega> AddEntrega(Entrega model)
        {
            try
            {
                _geralPersist.Add<Entrega>(model);
                if(await _geralPersist.SaveChangesAsync())
                {
                    return await _entregaPersist.GetEntregaByIdAsync(model.Id, false);
                }
                return null;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Entrega> UpdateEntrega(int id, Entrega model)
        {
            try
            {
                var entrega = await _entregaPersist.GetEntregaByIdAsync(id);
                if (entrega == null) return null;

                entrega.Cargas = model.Cargas;
                entrega.Data_Coleta = model.Data_Coleta;


                _geralPersist.Update(model);
                if (await _geralPersist.SaveChangesAsync())
                {
                    return await _entregaPersist.GetEntregaByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteEntrega(int EntregaId)
        {
            try
            {
                var entregaDelete = _entregaPersist.GetEntregaByIdAsync(EntregaId, false);
                if (entregaDelete == null) throw new Exception("Carga não encontrada");

                _geralPersist.Delete(entregaDelete);

                return await _geralPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Entrega[]> GetAllEntregaAsync(bool includeCarga = false)
        {
            try
            {
                var entregas = await _entregaPersist.GetAllEntregasAsync(includeCarga);
                if (entregas == null) return null;

                return entregas;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Entrega> GetEntregaByIdAsync(int id, bool includeCarga = false)
        {
            try
            {
                var entrega = await _entregaPersist.GetEntregaByIdAsync(id);
                if (entrega == null) return null;

                return entrega;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
