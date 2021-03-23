<template>
    <v-main>
        <h1>Look at all these cats!</h1>
        <div>
            <v-card elevation = "8">
                <v-card-title>{{name}}</v-card-title>
                <v-card-subtitle> {{age}}, {{gender}} </v-card-subtitle>
                <v-card-subtitle> A {{breed}} kitty located at Shelter {{shelterId}}</v-card-subtitle>
                <v-card-actions></v-card-actions>

            </v-card>
        </div>
    </v-main>
</template>


<script>
import api from '../CatServices';

export default {
    name: 'AllCats',
    
    mounted(){
      const cats = api.getAll;
      console.log(cats);
      this.cats = cats;
    }
}
</script>
