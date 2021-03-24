<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
      <Header />
    
    </v-app-bar>

    <v-main>
      <h1>Welcome to Shelter Pets!</h1> 

      <AllCats :cats="cats"/>


      <div v-on:click="updateCatsList()">Button</div>
    </v-main>
  </v-app>
</template>

<script>
import Header from './components/Header';
import shelterService from './API/ShelterService';
import catService from './API/CatService';

import AllCats from './components/AllCats.vue';
export default {
  name: 'App',

  components: {
    Header,
    AllCats
  },
  methods: {
    updateCatsList() {
      this.cats = catService.getAll();
      console.log(this.cats);
    },
    getStuff() {
      shelterService.get();
    }
  },
  mounted() {
    this.updateCatsList();
  },
  data:function() {
    return {
      cats: []
    };
  }
}
</script>
