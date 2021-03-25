<template>
  <v-main>
    <h1>Add a Kitty!</h1>
    <div class="form">
      <label for="cat.catId">
        Cat's ID: <input v-model="cat.catId" type="text" id="catId" />
      </label>
      <label for="cat.name">
        Cat's Name: <input v-model="cat.name" type="text" id="name" />
      </label>
      <label for="cat.age">
        Age: <input v-model="cat.age" type="text" id="age" />
      </label>
      <label for="cat.gender">
        Gender: <input v-model="cat.gender" type="text" id="gender" />
      </label>
      <label for="cat.breed">
        Breed and Coloring: <input v-model="cat.breed" type="text" id="breed" />
      </label>
      <label for="cat.shelterId">
        Shelter: <input v-model="cat.shelterId" type="text" id="shelterId" />
      </label>
      <button v-on:click="addCat(cat)">Add the Kitty</button>
      <span v-show="error" class="error"
        >Oopsie! ID, Name, Gender, and Shelter are Required.</span
      >
    </div>
  </v-main>
</template>

<script>
import CatService from "../API/CatService";

export default {
  name: 'AddCat',
  data: function () {
    return {
      error: false,
      cat: {
        catId: '',
        name: '',
        age: '',
        gender: '',
        breed: '',
        shelterId: ''
      }
    };
  },

  methods: {
    addCat(cat) {
       if (cat.catId === '' || cat.name === '' || cat.gender === '' || cat.shelterId === '') {
                this.error = true;
       } else {
            CatService.create(cat)
            cat.catId = '',
            cat.name = '',
            cat.age = '',
            cat.gender = '',
            cat.breed = '',
            cat.shelterId = ''
        }
      
    },
   
  },
};
</script>

<style scoped>
</style>