<template>
  <div class="footer">
    <h1>We are</h1>
    <h1 class="typing"></h1>
  </div>
</template>

<script>
export default {
  name: "Footer",
  mounted() {
    this.typing();
  },
  methods: {
    typing() {
      const texts = ["Professional.", "", "Trustworthy.", "", "LawyerUp."];
      let count = 0;
      let index = 0;
      let currentText = "";
      let letter = "";

      (function type() {
        if (count === texts.length) {
          count = 0;
        }
        currentText = texts[count];
        letter = currentText.slice(0, ++index);

        document.querySelector(".typing").textContent = letter;
        if (letter.length === currentText.length) {
          count++;
          index = 0;
          setTimeout(type, 1000);
        } else {
          setTimeout(type, 500);
        }
      })();
    },
  },
};
</script>

<style scoped>
.footer {
  display: flex;
  color: white;
  height: 20vh;
  background-color: rgb(0, 0, 0);
  align-items: center;
  justify-content:left;
  padding-left: 2rem;
  font-family: "Poppins", sans-serif;
  bottom: 0;
  margin-top: 5vh;
}
.typing {
  margin-left: 10px;
  animation: animte 5s linear infinite;
  /* margin-left: 10px;
  position: relative;
  background: url(https://wallpaperaccess.com/full/1871775.jpg);
  background-clip: text;
  background-size: cover;
  -webkit-background-clip: text;
  color: transparent; */
}
h1{
  font-size: 1.8rem;
  font-weight: 800;
  letter-spacing: 5px;
  color: #0e3742;
  text-transform: uppercase;
  text-align: center;
  -webkit-box-reflect: below 0px linear-gradient(transparent,#0008);
  line-height: 0.7em;
  outline: none;
  color: white;
    text-shadow: 0 0 10px #03bcf4,
     0 0 20px #03bcf4,
     0 0 40px #03bcf4,
     0 0 80px #03bcf4,
     0 0 1600px #03bcf4;
}
.typing{
  font-size: 2.5rem;
  font-weight: 1000;
}
.typing::after {
  content: "";
  width: 10px;
  height: 30%;
  border-right: 5px solid rgb(255, 255, 255);
  animation: blink 0.5s infinite ease;
}
@keyframes blink {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
@keyframes animate{
  0%{
    color: #0e3742;
    text-shadow: none;
  }
  100%{
    color: white;
    text-shadow: 0 0 10px #03bcf4,
     0 0 20px #03bcf4,
     0 0 40px #03bcf4,
     0 0 80px #03bcf4,
     0 0 1600px #03bcf4;
  
  }
}
</style>