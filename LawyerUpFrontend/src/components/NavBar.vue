<template>
  <div>
    <nav id="navbar" class="navbar">
      <div class="logo">
        <div class="formAbsolute">
          <div class="form">
            <form @submit.prevent="postData" id="form">
              <input
                class="input"
                type="text"
                name="search"
                autocomplete="off"
                required
              />
              <button type="submit"></button>
            </form>
            <label for="name" class="label-name" id="label-name">
              <span class="content-name" id="content-name"
                >輸入律師姓名、案件類型或關鍵字</span
              >
            </label>
          </div>
        </div>
      </div>
      <ul class="nav-links">
        <li><router-link to="/">首頁</router-link></li>
        <li><router-link to="/LawyerConsult">律師諮詢</router-link></li>
        <li><router-link to="/lawyer">律師檢索</router-link></li>
        <li @click="showMsgBoxTwo">
          <router-link to="/UserCharge">升級Premium</router-link>
        </li>
        <li v-b-modal.modal-2>註冊/登入</li>
      </ul>
      <div class="burger">
        <div class="line1"></div>
        <div class="line2"></div>
        <div class="line3"></div>
      </div>
    </nav>
    <login></login>
    <router-view></router-view>
  </div>
</template>

<script>
import axios from "axios";
import TimelineLite from "gsap";
import Vue from "vue";
import VueAxios from "vue-axios";
import Login from "./Login.vue";

Vue.use(VueAxios, axios);

export default {
  name: "NavBar",
  components: {
    Login,
  },
  computed: {},
  data() {
    return {
      boxTwo: "",
      resultp: {
        first: null,
        second: null,
        third: null,
      },
      results: undefined,
    };
  },
  mounted() {
    this.clickburger();
    this.fullpage();
    this.scroll();

    // this.backcolor();
  },
  methods: {
    turn() {
      axios
        .post("", {})
        .then(() => {})
        .catch((error) => console.error("There was an error!", error));
    },
    async postData() {
      this.$store.state.query = document.querySelector(".input").value;
      this.$store.state.results = undefined;
      //window.alert("predicting..."); /*jump alert out*/
      this.$router.push({ path: "/searchresult" });
      axios
        .post("http://140.123.174.200/api/Search", {
          searchQuery: this.$store.state.query,
        })
        .then((resp) => {
          if (resp.status === 200) {
            console.log(resp.data);
            this.$store.state.results = resp.data.data;
          }else if(resp.status === 204){
            this.$store.state.results = null;
            window.alert("無資料");
            
          }
        })
        .catch(function (error) {
          if (error.response) {
            console.log(error.response.status);
          }
        });
      this.$store.commit('clearResultp');
      axios
        .post("http://140.123.174.200/api/PredictionModel", {
          query: this.$store.state.query,
        })
        .then((response) => {
          (this.$store.state.resultp.first = response.data.first),
            (this.$store.state.resultp.second = response.data.second),
            (this.$store.state.resultp.third = response.data.third);
          console.log(response);
          //window.alert("完成");
        });
    },
    clickburger() {
      const navSlide = () => {
        const burger = document.querySelector(".burger");
        const nav = document.querySelector(".nav-links");

        burger.addEventListener("click", () => {
          nav.classList.toggle("nav-active");
          burger.classList.toggle("toggle");
        });
      };
      navSlide();
    },
    backcolor() {
      const slider = document.querySelector(".backcolor");

      TimelineLite.fromTo(
        slider,
        1.4,
        { x: "-100%" },
        { x: "0%", ease: TimelineLite.easeInOut },
        "+=10"
      );
    },
    fullpage() {
      TimelineLite.fromTo(
        ".navbar",
        1,
        { y: "-10vh", opacity: 0 },
        { y: "0%", opacity: 1, ease: TimelineLite.easeInOut },
        "+=0.8"
      );
    },
    scroll() {
      var prevScrollpos = 0;
      window.addEventListener("scroll", function () {
        var currentScrollpos = window.pageYOffset;
        // console.log(currentScrollpos);
        if (prevScrollpos > currentScrollpos) {
          document.getElementById("navbar").style.top = "0px";
        } else {
          document.getElementById("navbar").style.top = "-100px";
        }
        prevScrollpos = currentScrollpos;
      });
    },
    showMsgBoxTwo() {
      this.boxTwo = "";
      this.$bvModal
        .msgBoxOk(
          "基本功能：1. 一天提供使用者三次免費查尋關鍵字推薦律師資訊。2. 免費查詢判決書、律師資訊。3. 提供各地區免費律師諮詢管道資訊；付費功能：1. 無限制查詢關鍵字推薦律師資訊。2. 線上限時諮詢律師。（15分鐘/次）",
          {
            title: "付費資訊",
            size: "md",
            buttonSize: "sm",
            okVariant: "success",
            headerClass: "p-2 border-bottom-0",
            footerClass: "p-2 border-top-0",
            centered: true,
          }
        )
        .then((value) => {
          this.boxTwo = value;
        });
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

form button {
  width: 2rem;
  height: 2rem;
  background: transparent;
  border-style: none;
  position: absolute;
  right: 0;
  top: 10px;
  background-image: url(https://cdn3.iconfinder.com/data/icons/flaticons-1/24/flaticon_search-512.png);
  background-size: cover;
}
#navbar {
  position: fixed;
  top: 0;
  transition: top 0.5s;
  width: 100vw;
  background-color: rgb(41, 41, 41);
  z-index: 2;
}
nav {
  display: flex;
  justify-content: space-around;
  align-items: center;
  font-family: "Poppins", sans-serif;
  height: 10vh;
  min-height: 70px;
}
.logo {
  color: white;
  text-transform: uppercase;
  letter-spacing: 4px;
  font-size: 2.5rem;
  display: flex;
  height: 10vh;
  width: 50vw;
}
.nav-links {
  display: flex;
  width: 50%;
  justify-content: space-around;
}
.nav-links li {
  list-style: none;
  margin: 0;
  color: white;
  font-size: 1.2rem;
  font-weight: 100;
  letter-spacing: 2px;
}
.nav-links a {
  text-decoration: none;
  letter-spacing: 2px;
  font-weight: bold;
  font-size: 1.2rem;
  font-weight: 100;
  color: white;
}
.burger {
  display: none;
  cursor: pointer;
}
.burger div {
  width: 40px;
  height: 5px;
  background-color: white;
  margin: 10px;
  transition: all 0.3s ease;
}
@media screen and (max-width: 1300px) {
  .nav-links {
    display: flex;
    width: 50%;
    justify-content: space-around;
  }
}
@media screen and (max-width: 1120px) {
  .nav-links {
    position: absolute;
    right: -40vw;
    top: 10vh;
    height: 90vh;
    z-index: 5;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 40%;
    background-color: brown;
    transform: translateX(0%);
    transition: transform 0.5s ease-in;
  }
  .nav-links li {
    margin: 1rem;
  }
  .burger {
    display: block;
  }
}
.nav-active {
  transform: translateX(-100%);
}
.toggle .line1 {
  transform: rotate(45deg) translate(12px, 10px);
}
.toggle .line2 {
  opacity: 0;
}
.toggle .line3 {
  transform: rotate(-45deg) translate(12px, -10px);
}
.backcolor {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 10vh;
  background: linear-gradient(to left, white, black);
  z-index: -1;
}
.formAbsolute {
  border-radius: 2rem;
  display: flex;
  z-index: 0;
  position: absolute;
  width: 45%;
  top: 2vh;
  left: 5%;
  height: 6.7vh;
  background-color: white;
  justify-content: center;
  align-items: center;
  min-width: 100px;
  min-height: 45px;
}
.form {
  width: 90%;
  position: relative;
  height: 50px;
  left: 0px;
  top: 0;
}
.form input {
  width: 90%;
  height: 82%;
  color: #595f6e;
  position: absolute;
  top: 1vh;
  border: none;
  outline: none;
  font-size: 1rem;
}
.form label {
  position: absolute;
  pointer-events: none;
  left: 0;
  width: 100%;
  height: 90%;
  border-bottom: 2px solid #595f6e;
}
.content-name {
  color: #595f6e;
  position: absolute;
  bottom: 0.6rem;
  left: 1rem;
  font-size: 1rem;
  transition: all 0.3s ease;
}
#form:focus-within + #label-name #content-name,
#form:valid + #label-name #content-name {
  transform: translateY(-60%);
  font-size: 14px;
  color: #5fa8d3;
}
</style>
