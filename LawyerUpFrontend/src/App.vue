<template>
  <div id="app">
    <NavBar />
    <Footer />
  </div>
</template>

<script>
import Footer from "./components/Footer.vue";
import NavBar from "./components/NavBar.vue";

export default {
  name: "App",

  components: {
    NavBar,
    Footer
  },
};
</script>

<style>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
body {
  overflow-x: hidden;
  min-width: 940px;
}
::-webkit-scrollbar {
  
}
</style>


// json-server --watch db.json