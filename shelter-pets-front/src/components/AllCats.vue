<template>
  <v-main>
    <h1>Look at all these cats!</h1>
    <div class="cards" 
          v-for="cat in cats" 
          v-bind:key="cat.catId">
      <v-card elevation="8" v-on:click="getThisCat(cat.catId)">
        <v-card-title> {{ cat.name }}</v-card-title>
        <v-card-subtitle>
          {{ cat.age }}-year-old {{ cat.gender }}
        </v-card-subtitle>
        <v-card-subtitle>
          A {{ cat.breed }} kitty located at Shelter {{ cat.shelterId }}
        </v-card-subtitle>
        <v-card-actions></v-card-actions>
      </v-card>
    </div>
  </v-main>
</template>


<script>
import CatService from "../API/CatService";
import router from "../router/index"


export default {
  name: 'AllCats',
  data: function () {
    return {
      cats: [],
    };
  },

  mounted() {
    this.getCats();
  },

  methods: {
    getCats() {
      CatService.getAll().then((cats) => {
        this.cats = cats;
        // console.log(this.cats);
      });
    },
    getThisCat(id) {
      router.push({ 
        name: 'Cat',
        params: id
      })
      CatService.getOne(id).then((cat) => {
        this.cat = cat[0];
        console.log(this.cat);
      })
    },
  },
};
</script>

<style scoped>
</style>
