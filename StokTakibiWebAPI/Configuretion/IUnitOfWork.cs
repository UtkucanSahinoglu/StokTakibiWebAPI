using System.Threading.Tasks;
using System;
using StokTakibiWebAPI.Repository.Interface;

namespace StokTakibiWebAPI.Configuretion
{
    public interface IUnitOfWork : IDisposable
    {
        IYedekParcaRepository yedekParcaRepository { get; }
        void CompleteSave();
    }
}
