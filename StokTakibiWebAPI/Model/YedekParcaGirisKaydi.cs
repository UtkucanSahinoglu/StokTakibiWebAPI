using System;

namespace StokTakibiWebAPI.Model
{
    public class YedekParcaGirisKaydi
    {
        public Guid Id { get; set; }
        public string GirisDeposu { get; set; }
        public DateTime GirisTarihi { get; set; }
        public string GirisBelgeNumarasi { get; set; }
        public string SatinAlinanFirma { get; set; }
        public string SeriNumarasi { get; set; }
        public int GirisMiktari { get; set; }
        public string Birimi { get; set; }
        //public virtual YedekParcaTanimi YedekParcaTanimi { get; set; }
    }
}
