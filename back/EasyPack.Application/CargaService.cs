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
    public class CargaService : ICargaService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly ICargaPersist _cargaPersist;

        public CargaService(IGeralPersist geralPersist, ICargaPersist cargaPersist)
        {
            _geralPersist = geralPersist;
            _cargaPersist = cargaPersist;
        }

        public async Task<Carga> AddCarga(Carga model)
        {
            try
            {
                _geralPersist.Add<Carga>(model);
                if (await _geralPersist.SaveChangesAsync())
                {
                    return await _cargaPersist.GetCargaByIdAsync(model.Id, false);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Carga> UpdateCarga(int id, Carga model)
        {
            try
            {
                var carga = await _cargaPersist.GetCargaByIdAsync(id);
                if (carga == null) return null;

                carga.Altura = model.Altura;
                carga.Comprimento = model.Comprimento;
                carga.Data_Entrega = model.Data_Entrega;
                carga.Largura = model.Largura;
                carga.Peso = model.Peso;


                _geralPersist.Update(model);
                if(await _geralPersist.SaveChangesAsync())
                {
                    return await _cargaPersist.GetCargaByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteCarga(int CargaId)
        {
            try
            {
                var cargaDelete = _cargaPersist.GetCargaByIdAsync(CargaId, false);
                if (cargaDelete == null) throw new Exception("Carga não encontrada");

                _geralPersist.Delete(cargaDelete);

                return await _geralPersist.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<Carga[]> GetAllCargaAsync(bool includeEntrega = false)
        {
            try
            {
                var cargas = await _cargaPersist.GetAllCargaAsync(includeEntrega);
                if (cargas == null) return null;

                return cargas;
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Carga> GetCargaByIdAsync(int id, bool includeEntrega = false)
        {
            try
            {
                var carga = await _cargaPersist.GetCargaByIdAsync(id);
                if (carga == null) return null;

                return carga;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
