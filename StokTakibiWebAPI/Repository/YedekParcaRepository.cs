using Microsoft.EntityFrameworkCore;
using StokTakibiWebAPI.ApiDbContext;
using StokTakibiWebAPI.Model;
using StokTakibiWebAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace StokTakibiWebAPI.Repository
{
    public class YedekParcaRepository : GenericRepository<YedekParca>, IYedekParcaRepository
    {
        private readonly StokTakipApiDbContext _context;

        public YedekParcaRepository(StokTakipApiDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<YedekParca>> GetAll()
        {
            var result = await _context.Set<YedekParca>().Include(x => x.YedekParcaTanimis).Include(x => x.CikisYapilanAracTanimis).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<CikisYapilanAracTanimi>> GetByAracBazindaParcaRaporu(string Plaka)
        {
            var result = await _context.CikisYapilanAracTanimi.Where(x => x.Plaka == Plaka).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<YedekParca>> GetByHareketRaporu(Guid Id)
        {
            var result = await _context.YedekParca.Where(x => x.Id == Id).ToListAsync();
            return result;
        }

        public async Task<YedekParca> GetById(Guid Id)
        {

            var result = await _context.YedekParca.SingleAsync(x => x.Id == Id);

            _context.Entry(result)
                    .Collection(x => x.YedekParcaTanimis)
                    .Load();
            return result;
        }

        public async Task<IEnumerable<YedekParca>> GetBySeriNumarasi(string SeriNumarasi)
        {
            var result = await _context.YedekParca.Where(x => x.SeriNumarasi == SeriNumarasi).ToListAsync();
            return result;
            //var result = await _context.YedekParca.SingleAsync(x => x.SeriNumarasi == SeriNumarasi);

            //_context.Entry(result)
            //        .Collection(x => x.YedekParcaTanimis)
            //        .Load();
            //return result;
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
