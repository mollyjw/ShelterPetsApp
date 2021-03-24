<template>
  <div class="app">
    <div class="nav">
      <Header />
      <router-link to="/"> Home </router-link> | 
      <router-link to="/cats">Cats</router-link> |
    </div>
    <router-view />
  </div>
</template>

<script>
import Header from "./components/Header"

export default {
  name: 'App',
  components: {
      Header
  }
}
</script>
