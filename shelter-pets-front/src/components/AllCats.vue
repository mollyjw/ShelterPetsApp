<template>
  <v-main>
    <h1>Look at all these cats!</h1>
    <div class="cards" v-for="cat in cats" v-bind:key="cat.catId">
      <Cat :name      = "cat.name"
           :age       = "cat.age"
           :gender    = "cat.gender"
           :breed     = "cat.breed"
           :shelterId = "cat.shelterId"/>
    </div>
  </v-main>
</template>


<script>
import Cat from "./Cat";

export default {
  components: {Cat},
  props: ["cats"],
  data() {
    return {}
  },

  mounted() {
  },

  methods: {
  },
};
</script>
