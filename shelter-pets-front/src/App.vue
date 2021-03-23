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

      <AllCats/>


      <div v-on:click="getStuff()">Button</div>
    </v-main>
  </v-app>
</template>

<script>
import Header from './components/Header';
import shelterService from './API/ShelterService';
import AllCats from './components/AllCats.vue';
export default {
  name: 'App',

  components: {
    Header,
    AllCats
  },
  methods: {
    getStuff() {
     shelterService.get()
    }
  },
  data: () => ({
    //
  }),
};
</script>
