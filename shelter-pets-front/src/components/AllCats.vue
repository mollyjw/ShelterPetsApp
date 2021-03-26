<template>
  <v-main>
    <h1 class="text-center mt-4">Look at all these cats!</h1>
    <v-container fluid grid-list-md>
      <v-layout row wrap>
        <v-flex v-for="cat in cats" v-bind:key="cat.catId" d-flex xs12 sm6 md4>
          <v-card
            class="catCard"
            elevation="8"
            color="secondary"
            height="100%"
            width="100%"
            style="margin: 4%"
          >
            <v-card-title>
              <router-link
                class="text-decoration-none"
                :to="{ name: 'Cat', params: { catId: cat.catId } }"
              >
                {{ cat.name }}
              </router-link>
            </v-card-title>
            <v-card-subtitle>
              {{ cat.age }}-year-old {{ cat.gender }}
            </v-card-subtitle>
            <v-card-subtitle>
              A {{ cat.breed }} kitty located at Shelter {{ cat.shelterId }}
            </v-card-subtitle>
            <v-card-actions></v-card-actions>
          </v-card>
        </v-flex>
      </v-layout>

      <div class="my-8 text-center">
        <v-tooltip bottom>
          <template v-slot:activator="{ on }">
            <v-btn v-on="on" 
              fab
              x-large
              color="accent">
              <router-link :to="{ name: 'AddCat' }" class="text-decoration-none">
                <v-icon class="white--text">mdi-plus</v-icon>
              </router-link>
            </v-btn>
          </template>
          <span>Add a Cat</span>
        </v-tooltip>
      </div>
    </v-container>
  </v-main>
</template>


<script>
import CatService from "../API/CatService";
import router from "../router/index";

export default {
  name: "AllCats",
  data: function () {
    return {
      cats: [],
    };
  },

  mounted() {
    this.getCats();
  },

  methods: {
    getCats() {
      CatService.getAll().then((cats) => {
        this.cats = cats;
        // console.log(this.cats);
      });
    },
    getThisCat(id) {
      router.push({
        name: "Cat",
        params: { catId: this.catId },
      });
      CatService.getOne(id).then((cat) => {
        this.cat = cat[0];
        console.log(this.cat);
      });
    },
  },
};
</script>

<style scoped>
</style>

