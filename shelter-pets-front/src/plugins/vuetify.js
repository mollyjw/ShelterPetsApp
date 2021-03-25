import Vue from 'vue';
import Vuetify from 'vuetify/lib/framework';
import colors from 'vuetify/lib/util/colors'
import 'vuetify/dist/vuetify.min.css';


Vue.use(Vuetify);

export default new Vuetify({
    icons: {
        iconfont: 'mdi' 
      },
    theme: {
        themes: {
            dark: false,
            light: {
                primary: colors.teal,
                secondary: colors.teal.lighten4,
                accent: colors.teal.darken4,
                error: colors.red.darken2, 
            }
        }
    }
})
