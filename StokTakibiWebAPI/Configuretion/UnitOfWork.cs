using StokTakibiWebAPI.ApiDbContext;
using StokTakibiWebAPI.Repository;
using StokTakibiWebAPI.Repository.Interface;
using System.Threading.Tasks;

namespace StokTakibiWebAPI.Configuretion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StokTakipApiDbContext _context;
        public IYedekParcaRepository yedekParcaRepository { get; private set; }

        public UnitOfWork(StokTakipApiDbContext context)
        {
            _context = context;
            yedekParcaRepository = new YedekParcaRepository(_context);
        }

        public void CompleteSave()
        {
             _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
