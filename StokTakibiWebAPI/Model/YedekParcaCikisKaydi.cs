using System;

namespace StokTakibiWebAPI.Model
{
    public class YedekParcaCikisKaydi
    {
        public Guid Id { get; set; }
        public string CikisDepo { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string SeriNumarasi { get; set; }
        public int CikisMiktari { get; set; }
        public string Birimi { get; set; }
        //public virtual CikisYapilanAracTanimi CikisYapilanAracTanimi { get; set; }
        //public virtual YedekParcaTanimi YedekParcaTanimi { get; set; }
    }
}
