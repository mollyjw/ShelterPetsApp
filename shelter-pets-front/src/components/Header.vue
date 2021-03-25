<template>
    <v-main color="primary">
        <v-toolbar color="primary">
            <router-link to="/">
                <v-toolbar-title class="white--text font-weight-bold">Shelter Pets</v-toolbar-title>
            </router-link>
            <v-spacer></v-spacer>
            <v-tooltip bottom>
                <template v-slot:activator="{ on }">
                    <v-btn v-on="on" icon>
                        <router-link to="/">  
                            <v-icon class="white--text">mdi-home</v-icon>
                        </router-link>
                    </v-btn>
                </template>
                <span>Home</span>
            </v-tooltip>
            <v-tooltip bottom>
                <template v-slot:activator="{ on }">
                   <v-btn v-on="on" icon>
                    <router-link to="/cats">  
                        <v-icon class="white--text">mdi-cat</v-icon>
                    </router-link>
                    </v-btn> 
                </template>
                <span>Cats</span>
            </v-tooltip>
        </v-toolbar>
    </v-main>
</template>

<script>
export default {
    name: 'Header',
}
</script>
