using System.Threading.Tasks;
using System;
using StokTakibiWebAPI.Model;
using System.Collections.Generic;

namespace StokTakibiWebAPI.Repository.Interface
{
    public interface IYedekParcaRepository
    {
        Task <YedekParca> GetById(int Id);
        Task <IEnumerable<YedekParca>> GetBySeriNumarasi(string SeriNumarasi);
        Task <IEnumerable<YedekParca>> GetByHareketRaporu(int Id);
        Task <IEnumerable<CikisYapilanAracTanimi>> GetByAracBazindaParcaRaporu(string Plaka);
    }
}
