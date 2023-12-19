<template>
  <div>
    <header>
      <section>
        <div class="jambotron">
          <img src="https://wallpaperaccess.com/full/1871775.jpg" alt="" />
          <h1 class="headline">LowerUp</h1>
          <div class="formAbsolute">
            <div class="form">
              <input type="text" name="name" autocomplete="off" required>
              <label for="name" class="label-name">
                <span class="content-name">Search</span>
              </label><img src="https://cdn3.iconfinder.com/data/icons/flaticons-1/24/flaticon_search-512.png" alt="" class="searchicon">
            </div>
          </div>
          <div class="response"></div>
        </div>
      </section>
    </header>

    <div class="slider"></div>
  </div>
</template>

<script scoped>
import TimelineLite from "gsap";


export default {
  name: "Animation",
  mounted() {
    this.anime();
  },
  methods: {
    anime() {
      const jambotron = document.querySelector(".jambotron");
      const slider = document.querySelector(".slider");
      const formAbsolute = document.querySelector(".formAbsolute");

      TimelineLite.fromTo(
        jambotron,
        0.5,
        { height: "0%" },
        { height: "100vh", ease: TimelineLite.easeIn }
      );
      TimelineLite.fromTo(
        jambotron,
        1,
        { height: "100vh" },
        { height: "100%", ease: TimelineLite.easeIn },
        "+=0.15"
      );
      TimelineLite.fromTo(
        slider,
        1.4,
        { x: "-100%" },
        { x: "0%", ease: TimelineLite.easeInOut },
        "+=0.2"
      );
      TimelineLite.fromTo(
        formAbsolute,
        1.4,
        { y: "-10vh",opacity:0 },
        { y: "0%",opacity:1, ease: TimelineLite.easeInOut },
        "-=1"
      );
    },
  },
};
</script>

<style >
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
.response{
  z-index: 5;
  background-color: orange;
  width: 20vw;
  height: 25vh;
  position: absolute;
  bottom: 10vh;
  right: 10vw;
}
.searchicon{
  position: absolute;
  width: 1.5rem;
  height: 1.5rem;
  top: 30%;
  right: 0%;
  opacity: 0.5;
}
.formAbsolute{
  border-radius: 2rem;
  display: flex;
  z-index: 2;
  position: absolute;
  width: 45%;
  top: 10vh;
  left: 28%;
  height: 60px;
  background-color: white;
  justify-content: center;
  align-items: center;
  min-width: 100px;
  
}
.form {
  width: 90%;
  position: relative;
  height: 50px;
  left: 0px;
  top: 0;
}
.form input {
  width: 100%;
  height: 100%;
  color: #595f6e;
  padding-top: 20px;
  border: none;
  outline: none;
}
.form label {
  position: absolute;
  pointer-events: none;
  left: 0;
  width: 100%;
  height: 100%;
  border-bottom: 2px solid #595f6e;
}
.content-name{
  color: #595f6e;;
  position: absolute;
  bottom: 0.65rem;
  left: 0px;
  transition: all 0.3s ease;
}
.form input:focus + .label-name .content-name,
.form input:valid + .label-name .content-name{
  transform: translateY(-130%);
  font-size: 14px;
  color: #5fa8d3;
}
.form input:focus + .searchicon,
.form input:valid + .searchicon{
  border: 10px solid #5fa8d3;
}
section {
  /* overflow: hidden; */
  display: flex;
  height: 80vh;
  justify-content: center;
  align-items: center;
}
.jambotron {
  height: 90vh;
  width: 100%;
  position: relative;
}
.jambotron::after {
  display: flex;
  content: "";
  background-color: black;
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  opacity: 0.35;
}
section img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.slider {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100vh;
  background: linear-gradient(to left, white, black);
  z-index: -1;
}
nav {
  display: grid;
  grid-template-columns: 10% 1fr 1fr 10%;
  min-height: 10vh;
  color: white;
  align-items: center;
  justify-items: left;
}
nav img {
  width: 4vw;
  height: 10vh;
  justify-self: left;
}
#logo {
  grid-column: 2/4;
  font-size: 24px;
}
.headline {
  position: absolute;
  top: 70%;
  left: 10%;
  color: rgb(255, 255, 255);
  font-size: 5rem;
  z-index: 3;
}
</style>