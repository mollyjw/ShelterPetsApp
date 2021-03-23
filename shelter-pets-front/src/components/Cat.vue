<template>
  <v-card elevation="8">
    <v-card-title>Cat Name</v-card-title>
    <v-card-subtitle> Age, Gender </v-card-subtitle>
    <v-card-subtitle>
      A breed kitty located at Shelter #
    </v-card-subtitle>
    <v-card-actions></v-card-actions>
  </v-card>
</template>

<script>
import CatService from '../API/CatService';
// const CatService = Service.get("cats");

export default {
    props: ["cats"],
    data() {
        return {
            catId: this.catId,
            name: this.name,
            gender: this.gender,
            age: this.age,
            breed: this.breed,
            shelterId: this.shelterId
        }
    },
    
    mounted(){
     this.getCatInfo(this.cats.catId)
    },

    methods: {
        getCatInfo(id) {
            CatService.getOne(id);
            console.log(CatService.getOne(id))
            // const {data} = await CatService.getOne(id);
            // this.catId = data.catId;
            // this.name = data.name;
            // this.gender = data.gender;
            // this.age = data.age;
            // this.shelterId = data.shelterId; 
        }
    }
}
</script>
