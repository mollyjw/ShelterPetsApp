<template>
  <div class="home">
    <v-carousel >
      <v-carousel-item
        v-for="(item,i) in items"
        :key="i"
        :src="item.src"
      ></v-carousel-item>
    </v-carousel>
    <v-card color="secondary">
      <v-card-text class="cardTitle">Shelter Pets</v-card-text>
      <v-card-text class="paragraph">
          Tickle my belly at your own peril i will pester for food when you're in the kitchen even if it's salad . Head nudges poop on floor and watch human clean up but sit in a box for hours. Present belly, scratch hand when stroked bite off human's toes or lick left leg for ninety minutes, still dirty open the door, let me out, let me out, let me-out, let me-aow, let meaow, meaow! Sleeps on my head in the middle of the night i crawl onto your chest and purr gently to help you sleep but licks paws, or meow but poop on the floor, break a planter, sprint, eat own hair, vomit hair, hiss, chirp at birds, eat a squirrel, hide from fireworks, lick toe beans, attack christmas tree so scratch me there, elevator butt. Licks paws.
      </v-card-text>
      <v-card-text class="paragraph">
          Meow meow you are my owner so here is a dead rat as lick i the shoes thinking longingly about tuna brine this human feeds me, litter kitter kitty litty little kitten big roar roar feed me. Cough refuse to drink water except out of someone's glass steal raw zucchini off kitchen counter. Wack the mini furry mouse catty ipsum. Sniff other cat's butt and hang jaw half open thereafter decide to want nothing to do with my owner today check cat door for ambush 10 times before coming in lies down but stretch. Hate dogs jump around on couch, meow constantly until given food, hiss at vacuum cleaner. Purr am in trouble, roll over, too cute for human to get mad. 
      </v-card-text>
      <v-card-subtitle class="thankyou">Thank you for your support!</v-card-subtitle>
    </v-card>
  </div>
</template>

<script>
export default {
  name: 'home',
  
  data () {
    return {
      items: [
        {
          src: 'https://cdn.grbj.com/wp-content/uploads/sites/143/2020/05/Carols-Ferals-e1589548288186.jpg'
        },
        {
          src: 'https://marvel-b1-cdn.bc0a.com/f00000000202027/www.wellnesspetfood.com/sites/default/files/styles/blog_feature/public/media/images/shutterstock_624899891.jpg?itok=6oc5qTdy'
        },
        {
          src: 'https://www.aspca.org/sites/default/files/keeping-animals-in-homes_pet-statistics_main-image.jpg'
        },
        {
          src: 'https://www.americanhumane.org/app/uploads/2018/04/shelter-cats-1024x618.jpg'
        },
        {
          src: 'https://images.squarespace-cdn.com/content/v1/5d7fb788e0b10079fa82a6f9/1587416427239-V1VKVZS5YHR9RAUZT3KD/ke17ZwdGBToddI8pDm48kPTrHXgsMrSIMwe6YW3w1AZ7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0k5fwC0WRNFJBIXiBeNI5fKTrY37saURwPBw8fO2esROAxn-RKSrlQamlL27g22X2A/Vienna+%26+Odessa'
        }
      ]
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
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

  .thankyou {
    text-align: center;
    font-size: xx-large;
    color: rgba(0,0,0, 1) !important;    

  }

  
</style>
