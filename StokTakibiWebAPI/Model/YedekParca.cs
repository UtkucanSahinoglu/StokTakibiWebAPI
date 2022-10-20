using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace StokTakibiWebAPI.Model
{
    public class YedekParca
    {
        public Guid Id { get; set; }
        public string GirisDepo { get; set; }
        public string GirisTarihi { get; set; }
        public string GirisBelgeNumarasi { get; set; }
        public string SatinAlinanFirma { get; set; }
        public string SeriNumarasi { get; set; }
        public int GirisMiktari { get; set; }
        public string Birimi { get; set; }
        public string CikisDepo { get; set; }
        public string CikisTarihi { get; set; }
        public int CikisMiktari { get; set; }
        public IEnumerable<YedekParcaTanimi> YedekParcaTanimis { get; set; }
        public IEnumerable<CikisYapilanAracTanimi> CikisYapilanAracTanimis { get; set; }

    }
}
