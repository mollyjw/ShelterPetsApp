<template>
  <v-main>
    <div class="singlecat"> 
      <v-card elevation="8" background="secondary">
        <v-card-title> {{ cat.name }}</v-card-title>
        <v-card-subtitle> {{ cat.age }}-year-old {{ cat.gender }} </v-card-subtitle>
        <v-card-subtitle>
          A {{ cat.breed }} kitty located at Shelter {{ cat.shelterId }}
        </v-card-subtitle>
        <button v-on:click="deleteCat(cat.catId)">Delete Cat</button>
        <v-card-actions></v-card-actions>
      </v-card>
    </div>
  </v-main>
</template>

<script>
import CatService from "../API/CatService";
import router from '../router';
 

export default {
  name: 'OneCat',
  data: function() {
    return {
      cat: {}
    };
  },

  mounted() {
    // console.log(this.$route.params.catId)
    var catId = this.$route.params.catId
    this.getCatInfo(catId);
  },

  methods: {
    getCatInfo(id) {
      CatService.getOne(id).then(cat => {
        this.cat = cat[0];
      // console.log(this.cat);
      })
    },
    deleteCat(id) {
      CatService.delete(id);
      router.go(-1);
    }
  },
};
</script>
