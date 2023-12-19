<template>
  <div class="canvas">
    <div class="containerOrigin">
      <!-- <h3>找律師</h3> -->
      <h2>LawyerUP</h2>
      <div class="pic">
        <div class="firstpic"></div>
        <div class="secondpic"></div>
        <div class="thirdpic">
          <video src="https://player.vimeo.com/external/487754958.sd.mp4?s=625f928ace8967e5fb864be4b5bab637ecc050c7&profile_id=165&oauth2_token_id=57447761" loop autoplay muted></video>
        </div>
        <div class="fourthpic"></div>
        <div class="fifthpic">
          <video src="https://player.vimeo.com/external/554832832.sd.mp4?s=2eea721b2438cb726a6440da476f03f79969d75e&profile_id=165&oauth2_token_id=57447761" loop autoplay muted></video>
        </div>
        <div class="sixthpic"></div>
      </div>

      <div class="vague"></div>
    </div>
  </div>
</template>

<script>
import anime from "animejs/lib/anime.es.js";
import ScrollReveal from "scrollreveal";

export default {
  name: "Title",

  mounted() {
    this.title();
    ScrollReveal({
      reset: true,
      distance: "100px",
      duration: 2500,
      interval: 0,
      scale: 0.8,
    });
    ScrollReveal().reveal(".firstpic", { delay: 200, origin: "left" });
    ScrollReveal().reveal(".secondpic", { delay: 250, origin: "bottom" });
    ScrollReveal().reveal(".thirdpic", { delay: 300 ,origin: "top"});
    ScrollReveal().reveal(".fourthpic", { delay: 350 ,origin: "right",distance:"50px"});
    ScrollReveal().reveal(".fifthpic", { delay: 350, origin: "bottom" ,distance:"200px"});
    ScrollReveal().reveal(".sixthpic", { delay: 250, origin: "right" ,distance:"300px"});
    
  },
  methods: {
    title() {
      (function animateBlocks() {
        anime({
          targets: ".block",
          translateX: function () {
            return anime.random(-700, 700);
          },
          translateY: function () {
            return anime.random(-500, 500);
          },
          scale: function () {
            return anime.random(1, 5);
          },

          endDelay: 500,
          easing: "linear",
          duration: 4000,
          delay: anime.stagger(20),
          complete: animateBlocks,
        });
      })();
    },
  },
};
</script>

<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: "poppins", sans-serif;
}
.pic{
  display: flex;
  z-index: -2;
  height: 100vh;
  background-color: black;
}
.firstpic {
  background-image: url(https://images.pexels.com/photos/5669619/pexels-photo-5669619.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
  height: 60vh;
  width: 14vw;
  background-size: cover;
  transform: translateY(15vh);
  margin: 1.5rem;
   box-shadow: 0 0 20px #03bcf4;

}
.secondpic {
  background-image: url(https://images.pexels.com/photos/4427622/pexels-photo-4427622.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
  height: 70vh;
  width: 16vw;
  transform: translateY(11vh);
  background-size: cover;
  margin: 1.5rem;
  box-shadow: 0 0 20px #03bcf4;
  background-position-x: -70px;
}
.thirdpic {
  height: 75vh;
  width: 20vw;
  transform: translateY(8vh);
  margin: 1.5rem;
  box-shadow: 0 0 20px #03bcf4;
  overflow: hidden;
}
.fourthpic {
  background-image: url(https://images.pexels.com/photos/694587/pexels-photo-694587.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
  height: 75vh;
  width: 20vw;
  transform: translateY(8vh);
  background-size: cover;
  background-position-x: -100px;
  margin: 1.5rem;
  box-shadow: 0 0 20px #03bcf4;
}
.fifthpic {
  background-image: transparent;
  height: 70vh;
  width: 16vw;
  transform: translateY(11vh);
  margin: 1.5rem;
  box-shadow: 0 0 20px #03bcf4;
  overflow: hidden;
}
.sixthpic {
  background-image: url(https://images.pexels.com/photos/8112128/pexels-photo-8112128.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
  height: 60vh;
  width: 14vw;
  background-size: cover;
  background-position-x: -40px;
  transform: translateY(15vh);
  margin: 1.5rem;
  box-shadow: 0 0 20px #03bcf4;
}
.block {
  position: absolute;
  width: 50px;
  height: 100px;
  background: linear-gradient(#f7984b, #ffeb7b);
}
.canvas {
  margin-top: 10vh;
  position: relative;
  overflow: hidden;
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 110vh;
  background: linear-gradient(#f7984b, #ffeb7b);
}
.containerOrigin {
  width: 100%;
  height: 90vh;
   background-image: url("https://images.unsplash.com/photo-1539035104074-dee66086b5e3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjI0MX0&auto=format&fit=crop&w=2550&q=80");
   transform: translateY(-10vh);
}
h2 {
  color: white;
  text-align: center;
  font-size: 12vw;
  line-height: 1em;
  font-weight: 900;
  z-index: 1;
 transform: translateY(50vh);
 position: absolute;
 left: 5vw;
}
h3 {
  color: white;
  text-align: center;
  font-size: 8vw;
  line-height: 1em;
  font-weight: 550;
  z-index: 1;
 transform: translateY(35vh);
 position: absolute;
 left: 20vw;
}
video{
  height: 100%;
  background-size: cover;
  transform: translateX(-50px);
}
</style>