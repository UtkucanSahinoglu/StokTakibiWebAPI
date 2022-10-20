using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokTakibiWebAPI.Model;
using StokTakibiWebAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StokTakibiWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YedekParcaController : ControllerBase
    {
        private readonly IYedekParcaService _yedekParcaService;

        public YedekParcaController(IYedekParcaService yedekParcaService)
        {
            _yedekParcaService = yedekParcaService;
        }
        [HttpPost("AddYedekParca")]
        public void AddYedekParca(YedekParca yedekParca)
        {
            _yedekParcaService.Add(yedekParca);
        }
        [HttpPut("UpdateYedekParcaCikis")]
        public void UpdateYedekParcaCikis(YedekParca yedekParca)
        {
            _yedekParcaService.Update(yedekParca);
        }
        //[HttpGet("GetById")]
        //public async Task<YedekParca> GetById(Guid Id)
        //{
        //    var result = await _yedekParcaService.GetById(Id);
        //    return result;
        //}
        [HttpGet("GetAllYedekParca")]
        public async Task<IEnumerable<YedekParca>> GetAllYedekParca()
        {
            return await _yedekParcaService.GetAll();
        }
        [HttpGet("GetBySeriNumarasi")]
        public async Task<IEnumerable<YedekParca>> GetBySeriNumarasi(string SeriNumarasi)
        {
            return await _yedekParcaService.GetBySeriNumarasi(SeriNumarasi);
        }
        [HttpGet("GetByAracBazindaParcaRaporu")]
        public async Task<IEnumerable<CikisYapilanAracTanimi>> GetByAracBazindaParcaRaporu(string Plaka)
        {
            return await _yedekParcaService.GetByAracBazindaParcaRaporu(Plaka);
        }
        [HttpGet("GetByHareketRaporu")]
        public async Task<IEnumerable<YedekParca>> GetByHareketRaporu(Guid Id)
        {
            return await _yedekParcaService.GetByHareketRaporu(Id);
        }

    }
}
