<template>
  <v-main>
    <h1>Look at all these cats!</h1>
    <div class="cards" v-for="cat in cats" v-bind:key="cat.catId">
      <v-card elevation="8">
        <v-card-title>Name: {{cat.name}}</v-card-title>
        <v-card-subtitle> {{cat.age}}, {{cat.gender}} </v-card-subtitle>
        <v-card-subtitle> A {{cat.breed}} kitty located at Shelter {{cat.shelterId}} </v-card-subtitle>
        <v-card-actions></v-card-actions>
      </v-card>
    </div>
  </v-main>
</template>


<script>
import CatService from "../API/CatService";

export default {
  props: ["cats"],
  data() {
    return {}
  },

  mounted() {
  },

  methods: {
    getCats() {
      var data = CatService.getAll();
      console.log(data);
      return data;
      // const {data} = await CatService.getOne(id);
      // this.catId = data.catId;
      // this.name = data.name;
      // this.gender = data.gender;
      // this.age = data.age;
      // this.shelterId = data.shelterId;
    },
  },
};
</script>
