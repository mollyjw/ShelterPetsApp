import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../components/Home.vue';
import AllCats from '../components/AllCats.vue';
import Cat from '../components/Cat.vue';

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
        component: AllCats,
        children: [
          {
            path: '/${id}', 
            name: 'Cat',
            component: Cat,
            // params: { id: int}
          }
        ]
      }
    ];

const router = new VueRouter({
    mode: "history",
    base: "",
    routes
})

export default router;
