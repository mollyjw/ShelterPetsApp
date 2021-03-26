<template>
  <v-form ref="form" v-model="error" lazy-validation>
    <v-container>
      <h1 text-center>Add a Cat</h1>
      <v-layout>
        <v-flex xs12 md6>
          <v-text-field
            v-model.number="cat.catId"
            label="Cat's ID"
            :rules="idRules"
            required
            style="margin: 2% 4%"
          >
          </v-text-field>
        </v-flex>

        <v-flex xs12 md6>
          <v-text-field
            v-model="cat.name"
            label="Cat's Name"
            :rules="nameRules"
            required
            style="margin: 2% 4%"
          ></v-text-field>
        </v-flex>
      </v-layout>

      <v-layout>
        <v-flex xs12 md6>
          <v-text-field 
            v-model="cat.age" 
            label="Age" 
            style="margin: 2% 4%"
          ></v-text-field>
        </v-flex>

        <v-flex>
          <v-select
            v-model="cat.gender"
            :items="genders"
            :rules="[(v) => !!v || 'Gender is required']"
            label="Gender"
            required
            style="margin: 2% 4%"
          ></v-select>
        </v-flex>
      </v-layout>

      <v-layout>
        <v-flex xs12 md6>
          <v-text-field
            v-model="cat.breed"
            label="Breed and Coloring"
            style="margin: 2% 4%"
          ></v-text-field>
        </v-flex>

        <v-flex xs12 md6>
          <v-text-field
            v-model="cat.shelterId"
            label="Shelter ID"
            :rules="shelterRules"
            required
            style="margin: 2% 4%"
          ></v-text-field>
        </v-flex>
      </v-layout>
      <v-layout>
        <v-flex xs12 md6 text-center>
          <v-btn v-on:click="addCat(cat)" color="accent" style="margin: 2% 4%"
            >Add the Kitty
          </v-btn>
        </v-flex>

        <v-flex xs12 md6 text-center>
          <v-btn v-on:click="resetForm()" color="accent" style="margin: 2% 4%"
            >Reset Form
          </v-btn>
        </v-flex>
      </v-layout>
    </v-container>
  </v-form>
</template>


<script>
import CatService from "../API/CatService";

export default {
  name: "AddCat",
  data: function () {
    return {
      error: false,
      idRules: [
        (v) => !!v || "ID is required",
        // (v) => (v && typeof[v] == Number) || "ID must be a number",
      ],
      nameRules: [
        (v) => !!v || "Name is required",
        (v) => (v && v.length >= 2) || "Name must be at least 2 characters",
      ],
      gender: null,
      genders: ["Male", "Female", "Unsure"],

      shelterRules: [
        (v) => !!v || "Shelter ID is required",
        (v) => (v && v == 1) || v == 2 || "Shelter ID must be 1 or 2",
      ],
      cat: {
        catId: "",
        name: "",
        age: "",
        gender: "",
        breed: "",
        shelterId: "",
      },
    };
  },

  methods: {
    resetForm() {
      this.$refs.form.reset();
    },
    addCat(cat) {
      if (this.$refs.form.validate()) {
        CatService.create(cat);
        this.resetForm();
      } 
    }
  },
};
</script>

<style scoped>
</style>