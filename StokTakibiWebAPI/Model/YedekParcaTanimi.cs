using System;
using System.Collections.Generic;

namespace StokTakibiWebAPI.Model
{
    public class YedekParcaTanimi
    {
        public int Id { get; set; }
        public int YedekParcaId { get; set; }
        public string Kodu { get; set; }
        public string Adi { get; set; }
        public virtual YedekParca YedekParca { get; set; }
        //public IEnumerable<YedekParcaCikisKaydi> YedekParcaCikisKaydis { get; set; }
        //public IEnumerable<YedekParcaGirisKaydi> YedekParcaGirises { get; set; }


    }
}
