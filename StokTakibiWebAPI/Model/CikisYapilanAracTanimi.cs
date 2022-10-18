using System;
using System.Collections.Generic;
using System.Net;

namespace StokTakibiWebAPI.Model
{
    public class CikisYapilanAracTanimi
    {
        public Guid Id { get; set; }
        public Guid YedekParcaId { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        //public IEnumerable<YedekParcaCikisKaydi> YedekParcaCikisKaydis { get; set; }
        public virtual YedekParca YedekParca { get; set; }

    }
}
