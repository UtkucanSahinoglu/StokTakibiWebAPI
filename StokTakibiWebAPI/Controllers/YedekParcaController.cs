using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<YedekParcaController> _logger;


        public YedekParcaController(IYedekParcaService yedekParcaService, ILogger<YedekParcaController> logger)
        {
            _yedekParcaService = yedekParcaService;
            _logger = logger;
        }
        [HttpPost("AddYedekParca")]
        public void AddYedekParca(YedekParca yedekParca)
        {
            _logger.LogInformation("AddYedekParca method is called");
            _yedekParcaService.Add(yedekParca);
        }
        [HttpPut("UpdateYedekParcaCikis")]
        public void UpdateYedekParcaCikis(YedekParca yedekParca)
        {
            _logger.LogInformation("UpdateYedekParcaCikis method is called");
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
            _logger.LogInformation("GetAllYedekParca method is called");
            return await _yedekParcaService.GetAll();
        }
        [HttpGet("GetBySeriNumarasi")]
        public async Task<IEnumerable<YedekParca>> GetBySeriNumarasi(string SeriNumarasi)
        {
            _logger.LogInformation("GetBySeriNumarasi method is called");
            return await _yedekParcaService.GetBySeriNumarasi(SeriNumarasi);
        }
        [HttpGet("GetByAracBazindaParcaRaporu")]
        public async Task<IEnumerable<CikisYapilanAracTanimi>> GetByAracBazindaParcaRaporu(string Plaka)
        {
            _logger.LogInformation("GetByAracBazindaParcaRaporu method is called");
            return await _yedekParcaService.GetByAracBazindaParcaRaporu(Plaka);
        }
        [HttpGet("GetByHareketRaporu")]
        public async Task<IEnumerable<YedekParca>> GetByHareketRaporu(int Id)
        {
            _logger.LogInformation("GetByHareketRaporu method is called");
            return await _yedekParcaService.GetByHareketRaporu(Id);
        }

    }
}
