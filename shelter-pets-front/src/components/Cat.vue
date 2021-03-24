<template>
  <v-main>
    <div> Cat {{$route.params.catId}}</div>
    <div class="singlecat">
      <v-card elevation="8">
        <v-card-title> {{ cat.name }}</v-card-title>
        <v-card-subtitle> {{ cat.age }}-year-old {{ cat.gender }} </v-card-subtitle>
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

export default {
  name: 'OneCat',
  data: function() {
    return {
      cat: {}
    };
  },

  mounted() {
    this.getCatInfo();
  },

  methods: {
    getCatInfo(id) {
      CatService.getOne(id).then(cat => {
        this.cat = cat[0];
      console.log(this.cat);
      })
    },
  },
};
</script>
