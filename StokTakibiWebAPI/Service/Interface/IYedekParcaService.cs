using StokTakibiWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StokTakibiWebAPI.Service.Interface
{
    public interface IYedekParcaService
    {
        Task<IEnumerable<YedekParca>> GetAll();
        void Add(YedekParca yedekParca);
        void Update(YedekParca yedekParca);
        Task<YedekParca> GetById(int Id);
        Task<IEnumerable<YedekParca>> GetBySeriNumarasi(string SeriNumarasi);
        Task<IEnumerable<YedekParca>> GetByHareketRaporu(int Id);
        Task<IEnumerable<CikisYapilanAracTanimi>> GetByAracBazindaParcaRaporu(string Plaka);

    }
}

