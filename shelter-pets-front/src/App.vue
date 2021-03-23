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
      <AllCats />
    </v-main>
  </v-app>
</template>

<script>
import Header from './components/Header';
import AllCats from './components/AllCats';

export default {
  name: 'App',

  components: {
    Header,
    AllCats
  },

  data: () => ({
    //
  }),
};
</script>
