<template>
  <div class="paginationpage">
    <div class="lawyercontainer">
      <div class="text-box">
        <Pagination v-on:changeurll="changeurl($event)" />
        <div class="distance">
<div v-for="item in list" :key="item.id" class="data">
          <div class="information" v-b-modal.modal-1 @click="detail(item.id)">
            <div class="space name">{{item.name}}</div>
            <div class="space sex">{{ item.sex }}</div>
            <div class="space guild_name">{{ item.guild_name }}</div>
            <div class="space email">{{ item.email }}</div>
            <div class="space tel">{{ item.tel }}</div>
          </div>
        </div>
        </div>
        
        <lawyer-modal :id="lawyerid"></lawyer-modal>
      </div>
    </div>
  </div>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";
import Pagination from "./Pagination.vue";
// import anime from 'animejs/lib/anime.es.js';
import LawyerModal from "./LawyerModal.vue";

Vue.use(VueAxios, axios);

export default {
  name: "Unit",
  components: {
    Pagination,
    LawyerModal,

  },
  data() {
    return {
      list: undefined,
      detaillist: {
        name: null,
      },
      url: "http://140.123.174.200/api/Lawyer/",
      lawyerid: undefined,
    };
  },
  mounted() {
    Vue.axios.get("http://140.123.174.200/api/Lawyer").then((resp) => {
      this.list = resp.data.data;
    });
    this.parallax();
  },
  methods: {
    // scrollto() {
    //   var element = document.querySelector(".detail");
    //   var target = element.offsetTop;

    //   window.scrollTo({ top: target, behavior: "smooth" });
    // },
    changeurl({ page, sex, guild }) {
      let url = "http://140.123.174.200/api/Lawyer?CurrentPage=";
      let sexString = "";
      let guildString="";
      if (page == null) {
        page = 1;
      }
      if (sex == true) {
        sexString = "&Sort=sex";
      }
      if(guild!=null){
        guildString="&Guild="+guild;
      } 
      url = url + page + sexString + guildString;
      Vue.axios.get(url).then((resp) => {
        this.list = resp.data.data;
        console.log(resp);
        console.log(url);
      });
    },
    detail(par) {
      this.lawyerid = par;
    },
    // parallax() {
    //   const parallax = document.querySelector(".container");
    //   window.addEventListener("scroll", function () {
    //     let offset = window.pageYOffset;
    //     parallax.style.backgroundPositionY = offset * 0.4 + "px";
    //   });
    // },
  },
};
</script>

<style scoped>
.distance{
  margin-top: 20vh;
}
.information {
  display: flex;
  min-width: 700px;
}
button {
  cursor: pointer;
}
/* .data:hover{
  background-color: rgb(147, 241, 248);
  
} */
.space {
  min-width: 10vw;
  height: 5vh;
  display: flex;
  justify-content: center;
  align-items: center;
}
.email {
  width: 20vw;
}
.data:hover {
  background-color: rgb(143, 210, 255);
  transform: scale(1.05);
  transition: 0.4s ease;
}
.lawyercontainer {
  background-color: #646670;
  height: 150vh;
  background-size: contain;
  justify-content: center;
  align-items: center;
  display: flex;
  flex-direction: column;
  z-index: 2;
}

.text-box {
  background: rgba(255, 255, 255, 0.1);
  backdrop-filter: blur(20px);
  padding: 30px;
  border: 1px solid rgba(255, 255, 255, 0.1);
  border-radius: 10px;
}
.paginationpage {
  margin-top: 10vh;
  height: 140vh;
  width: 100vw;
}

a,
a:visited {
  color: blue;
  text-decoration: none;
}
.data {
  width: 60vw;
  margin: 1rem;
  padding: 0.5rem;
  border-radius: 10px;
  background-color: white;
}
.data button {
  background: transparent;
  border: none;
  font-size: 1.5rem;
  color: rgba(0, 0, 255, 0.911);
}
.detail {
  margin-top: 10vh;
  margin-bottom: 10vh;
}
</style>