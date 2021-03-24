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
    </v-main>
  </v-app>
</template>

<script>
import Header from './components/Header';
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
