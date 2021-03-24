<template>
  <div>
    <v-card elevation="8">
      <v-card-title>Name: {{name}}</v-card-title>
      <v-card-subtitle> {{age}}, {{gender}} </v-card-subtitle>
      <v-card-subtitle> A {{breed}} kitty located at Shelter {{shelterId}} </v-card-subtitle>
      <v-card-actions></v-card-actions>
    </v-card>

    <br/>
  </div>
</template>

<script>

export default {
    props: ["name", "age", "gender", "breed", "shelterId"],

    data() {
      return {}
    },
    
    mounted(){
    },

    methods: {
    }
}
</script>

