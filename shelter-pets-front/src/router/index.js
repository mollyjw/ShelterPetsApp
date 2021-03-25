import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../components/Home.vue';
import AllCats from '../components/AllCats.vue';
import Cat from '../components/Cat.vue';
import AddCat from '../components/AddCat.vue'

Vue.use(VueRouter)

const routes = [
      {
        path: '/',
        name: "home",
        component: Home
      },
      {
        path: '/cats',
        name: "AllCats",
        component: AllCats
      },
      {
        path: '/cats/:catId}', 
        name: 'Cat',
        component: Cat
      },
      {
        path: '/cats/add',
        name: 'AddCat',
        component: AddCat
      }
    ];

const router = new VueRouter({
    mode: "history",
    base: "",
    routes
})

export default router;
