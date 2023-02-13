<template>
  <main>
    <NavBar :logo="logo_src" :alt="app_name" />
    <router-view/>
    <FooterHome/>
  </main>
</template>

<script> 
import NavBar from './components/NavBar.vue'
import FooterHome from './components/Footer.vue'
export default {
 components: {
   NavBar,
   FooterHome
 },
 data(){
   return{
     logo_src: '/img/logo.png',
     app_name: 'Make Your Burger'
   }
 }
}
</script>


<style>
*{
 font-family: Helvetica;
 padding: 0;
 margin: 0;
 box-sizing: border-box;
}
.main-container{
 margin: 50px;
 min-height: 250px;
}
h1{
 text-align: center;
 font-size: 42px;
 margin-bottom: 30px;
 color: #222;
}
</style>