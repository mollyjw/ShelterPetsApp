<template>
  <v-app class="">
  <div class="app">
    <div class="nav">
      <Header />
    </div>
    <router-view />
  </div>
  </v-app>
</template>

<script>
import Header from "./components/Header"
import Router from "./router/index"

export default {
  name: 'App',
  router: Router,
  components: {
      Header
  }
}
</script>
