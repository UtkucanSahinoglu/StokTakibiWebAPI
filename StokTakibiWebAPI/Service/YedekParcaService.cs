using StokTakibiWebAPI.ApiDbContext;
using StokTakibiWebAPI.Configuretion;
using StokTakibiWebAPI.Model;
using StokTakibiWebAPI.Repository.Interface;
using StokTakibiWebAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StokTakibiWebAPI.Service
{
    public class YedekParcaService : IYedekParcaService
    {
        private readonly IGenericRepository<YedekParca> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IYedekParcaRepository _yedekParcaRepository;
        private readonly StokTakipApiDbContext _context;

        public YedekParcaService(IGenericRepository<YedekParca> repository, IUnitOfWork unitOfWork, IYedekParcaRepository yedekParcaRepository, StokTakipApiDbContext context)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _yedekParcaRepository = yedekParcaRepository;
            _context = context;
        }
        public void Add(YedekParca yedekParca)
        {
            using var Transaction = _context.Database.BeginTransaction();
            try
            {
                _repository.Add(yedekParca);
                _unitOfWork.CompleteSave();
                Transaction.Commit();
            }
            catch
            {
                Transaction.Rollback();
            }
        }

        public async Task<IEnumerable<YedekParca>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<CikisYapilanAracTanimi>> GetByAracBazindaParcaRaporu(string Plaka)
        {
            return await _yedekParcaRepository.GetByAracBazindaParcaRaporu(Plaka);
        }

        public async Task<IEnumerable<YedekParca>> GetByHareketRaporu(Guid Id)
        {
            return await _yedekParcaRepository.GetByHareketRaporu(Id);
        }

        public async Task<YedekParca> GetById(Guid Id)
        {
            return await _yedekParcaRepository.GetById(Id);
        }

        public async Task<IEnumerable<YedekParca>> GetBySeriNumarasi(string SeriNumarasi)
        {
            return await _yedekParcaRepository.GetBySeriNumarasi(SeriNumarasi);
        }

        public void Update(YedekParca yedekParca)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _repository.Update(yedekParca);
                _unitOfWork.CompleteSave();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
        }
    }
}
