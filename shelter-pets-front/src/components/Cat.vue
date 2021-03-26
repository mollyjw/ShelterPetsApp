<template>
  
      <v-layout row-wrap>
        <v-flex xs12>
            <v-card color="secondary" elevation="8" style="margin: 3%">
              <v-layout row>
                <v-flex xs6 style="margin: 3%">
                  <v-card-title class="cardTitle">{{cat.name}}</v-card-title>
                  <v-card-subtitle class="paragraph">
                    <div>
                      <div class="pt-6 pb-3 px-3"> {{ cat.age }}-year-old {{ cat.gender }}</div>
                      <div class="pa-3">A {{ cat.breed }} kitty located at Shelter {{ cat.shelterId }}</div>
                    </div>
                  </v-card-subtitle>
                  <v-divider light></v-divider>
                  <v-card-actions class="pa-3" text-center>
                    <div class="my-2" text-center>
                      <v-btn
                      x-large
                      color="accent"
                      v-on:click="deleteCat(cat.catId)"
                      >
                      Delete Cat
                      </v-btn>
                    </div>
                  </v-card-actions>
                </v-flex>
                <v-flex xs5 style="margin: 2% -1%">
                  <v-img
                    src="http://placekitten.com/400/300"
                    contain
                  ></v-img>
                </v-flex>
              </v-layout>
              
            </v-card>
          </v-flex>
      </v-layout>

</template>

<script>
import CatService from "../API/CatService";
import router from "../router";

export default {
  name: "OneCat",
  data: function () {
    return {
      cat: {},
    };
  },

  mounted() {
    // console.log(this.$route.params.catId)
    var catId = this.$route.params.catId;
    this.getCatInfo(catId);
  },

  methods: {
    getCatInfo(id) {
      CatService.getOne(id).then((cat) => {
        this.cat = cat[0];
        // console.log(this.cat);
      });
    },
    deleteCat(id) {
      CatService.delete(id);
      router.go(-1);
    },
  },
};
</script>

<style scoped>
  .cardTitle {
    font-size: xxx-large;
    text-align: center;
    color: rgba(0,0,0, 1) !important;
    padding-top: 2%;
  }

  .paragraph {
    color: rgba(0,0,0, 1) !important;    
    font-size: 1.2rem;
    font-weight: 400;
    line-height: 2rem;
  }
</style>