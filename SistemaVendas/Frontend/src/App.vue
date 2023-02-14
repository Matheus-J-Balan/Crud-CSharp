<template>
  <main>
    <NavBar :logo="logo_src" :alt="app_name" />
    <router-view/>
  </main>
</template>

<script> 
import NavBar from './components/NavBar.vue'
export default {
 components: {
   NavBar,
 }
}
</script>


<style>
.center{
  justify-content: center;
  align-items: center;
}
</style>