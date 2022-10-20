<template>
  <div class="YedekParcaGiris">
    <form class="kayitForm" @submit="postYedekParcaData" method="post">
      <input
        class="postgirisdepo"
        type="text"
        name="girisdepo"
        placeholder="Giris yapilan depo adi"
        required
        v-model="postsYedekParca.girisdepo"
      />
      <label class="labelgirisdepo" for="girisdepo">Giris Depo Adi</label><br />

      <input
        class="postgiristarihi"
        type="text"
        name="giristarihi"
        placeholder="parca giris tarihini giriniz"
        required
        v-model="postsYedekParca.giristarihi"
      />
      <label class="labelgiristarihi" for="giristarihi"
        >Parca Giris Tarihi</label
      ><br />

      <input
        class="postgirisbelgenumarasi"
        type="text"
        name="girisbelgenumarasi"
        placeholder="Giris belge numarasini giriniz"
        required
        v-model="postsYedekParca.girisbelgenumarasi"
      />
      <label class="labelgirisbelgenumarasi" for="girisbelgenumarasi"
        >Belge Numarasi</label
      ><br />

      <input
        class="postsatinalinanfirma"
        type="text"
        name="satinalinanfirma"
        placeholder="Satin alinan firma adini giriniz"
        required
        v-model="postsYedekParca.satinalinanfirma"
      />
      <label class="labelsatinalinanfirma" for="satinalinanfirma"
        >Firma Adi</label
      ><br />

      <input
        class="postserinumarasi"
        type="text"
        name="serinumarasi"
        placeholder="Parca seri numarasini giriniz"
        required
        v-model="postsYedekParca.serinumarasi"
      />
      <label class="labelserinumarasi" for="serinumarasi">Seri Numarasi</label
      ><br />

      <input
        class="postgirismiktari"
        type="text"
        name="giris miktari"
        placeholder="Parca giris miktarini giriniz"
        required
        v-model="postsYedekParca.girismiktari"
      />
      <label class="labelgirismiktari" for="girismiktari">Giris Miktari</label
      ><br />

      <input
        class="postbirimi"
        type="text"
        name="birimi"
        placeholder="yedek parca birimini giriniz"
        required
        v-model="postsYedekParca.birimi"
      />
      <label class="labelbirimi" for="birimi">Birimi</label><br />
      <input
        class="postkodu"
        type="text"
        name="kodu"
        placeholder="Parca kodunu giriniz"
        required
        v-model="postsYedekParcaTanimi.kodu"
      />
      <label class="labelkodu" for="kodu">Parca Kodu</label><br />

      <br />
      <br />
      <input
        class="postAdi"
        type="text"
        name="adi"
        placeholder="Parca adini giriniz"
        v-model="postsYedekParcaTanimi.adi"
      />
      <label class="labeladi" for="adi">Parca Adi</label><br />
      <br />
      <br />
      <b-button class="YedekParcaGirisKaydi" type="submit"
        >Yedek Parca Kaydet</b-button
      >
    </form>
  </div>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";
import Swal from "sweetalert2/dist/sweetalert2.js";

Vue.use(VueAxios, axios);

export default {
  name: "PostComponent",
  data() {
    return {
      postsYedekParca: {
        girisdepo: null,
        giristarihi: null,
        girisbelgenumarasi: null,
        satinalinanfirma: null,
        serinumarasi: null,
        girismiktari: null,
        birimi: null,
        yedekparcatanimi: [],
      },
      postsYedekParcaTanimi: {
        kodu: null,
        adi: null,
      },
    };
  },
  methods: {
    postYedekParcaData(e) {
      e.preventDefault();
      Swal.fire("Kullanici eklendi");
      console.log(this.postsYedekParcaTanimi);
      axios
        .post(
          "https://localhost:5001/YedekParca/AddYedekParca",
          this.postsYedekParca
        )
        .then((result) => {
          window.location.reload();
          console.warn(result);
        });
      this.$bvModal.hide("YedekParcaGirisKaydi");
      e.preventDefault();

      return;
    },
  },
  mounted() {
    console.log(this.postsYedekParca);
    console.log(this.postsYedekParcaTanimi);
  },
};
</script>
<style>
label.labelgirisdepo {
  margin-top: 0px;
  margin-right: 360px;
}
input.postgirisdepo {
  position: absolute;
  margin-top: 0px;
  margin-left: 130px;
  width: 300px;
}
label.labelgiristarihi {
  margin-top: 0px;
  margin-right: 350px;
}
input.postgiristarihi {
  position: absolute;
  margin-top: 0px;
  margin-left: 130px;
  width: 300px;
}
label.labelgirisbelgenumarasi {
  margin-top: 0px;
  margin-right: 350px;
}
input.postgirisbelgenumarasi {
  position: absolute;
  margin-top: 0px;
  margin-left: 130px;
  width: 300px;
}
label.labelsatinalinanfirma {
  margin-top: 0px;
  margin-right: 350px;
}
input.postsatinalinanfirma {
  position: absolute;
  margin-top: 0px;
  margin-left: 110px;
  width: 300px;
}
label.labelserinumarasi {
  margin-top: 0px;
  margin-right: 350px;
}
input.postserinumarasi {
  position: absolute;
  margin-top: 0px;
  margin-left: 125px;
  width: 300px;
}
label.labelgirismiktari {
  margin-top: 0px;
  margin-right: 350px;
}
input.postgirismiktari {
  position: absolute;
  margin-top: 0px;
  margin-left: 115px;
  width: 300px;
}
label.labelbirimi {
  margin-top: 0px;
  margin-right: 350px;
}
input.postbirimi {
  position: absolute;
  margin-top: 0px;
  margin-left: 95px;
  width: 300px;
}
label.labelkodu {
  margin-top: 0px;
  margin-right: 350px;
}
input.postkodu {
  position: absolute;
  margin-top: 0px;
  margin-left: 115px;
  width: 300px;
}
label.labeladi {
  margin-top: 0px;
  margin-right: 350px;
}
input.postAdi {
  position: absolute;
  margin-top: 0px;
  margin-left: 110px;
  width: 300px;
}
</style>
