<template>
  <div class="AppClass" id="app">
    <h3 class="h3Stok">Stok Takibi <b-badge variant="light">Light</b-badge></h3>
    <div>
      <b-button
        class="YedekParcaGirisKaydiButton"
        id="show-btn"
        @click="showModal"
        >Yedek Parça Giriş Kaydı
      </b-button>
      <b-modal
        id="YedekParcaGirisKaydi"
        class="YedekParcaGirisKaydiPopup"
        ref="my-modal"
        hide-footer
        title="Yedek Parca Giris Kaydi"
      >
        <div class="d-block text-center">
          <yedek-parca-giris-kaydi />
        </div>
      </b-modal>
    </div>
    <all-yedek-parca />
  </div>
</template>

<script>
import YedekParcaGirisKaydi from "./components/YedekParcaGirisKaydi.vue";
import AllYedekParca from "./components/AllYedekParca.vue";

export default {
  name: "App",
  components: {
    YedekParcaGirisKaydi,
    AllYedekParca,
  },
  methods: {
    showModal() {
      this.$bvModal.show("YedekParcaGirisKaydi");
    },
  },
};
</script>

<style>
h3.h3Stok {
  margin-left: 600px;
}
button.YedekParcaGirisKaydiButton {
  margin-left: 1200px;
}
</style>
