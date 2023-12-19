<template>
  <div class="about">
    <div class="blockdisplay">
      <div class="eventDetail">
        <div class="informationFirstLine">
          <div class="year">{{ eventDetail.year }}</div>
          <div class="word">{{ eventDetail.word }}</div>
          <div class="number">{{ eventDetail.number }}</div>
          <div class="classification">{{ eventDetail.classification }}</div>
          <div class="courtCode">{{ eventDetail.courtCode }}</div>
        </div>
        <br />
        <h3>主文</h3>
        <div class="mainContent">{{ eventDetail.mainContent }}</div>
        <!-- <div class="beforeMain">{{ eventDetail.beforeMain }}</div> -->
        <h3>事實及理由</h3>
        <div class="factReason">{{ eventDetail.factReason }}</div>
        <h3>判決日期</h3>
        <div class="judgeDate">{{ eventDetail.judgeDate }}</div>
      </div>
      <button class="close" @click="cancel"></button>
    </div>
    <div class="result">
      
      <div class="record">
        <div class="loadinggif" v-if="results === undefined">
        <img src="../assets/loading.gif"  width="96px"/>
        <h3>Loading...</h3>
        </div>
        <div class="loadinggif" v-if="results === null">
        <h3>查無相關判決資料！</h3>
        <h4 v-if='this.$store.state.resultp.first!=""'>可點擊右方推測案由查詢相關判決</h4>
        </div>
        <div v-for="item in results" :key="item.id" class="data">
          <div class="information">
            <div class="space">{{ item.classification }}</div>
            <div class="space">{{ item.type }}</div>
            <div class="space">{{ item.year }}</div>
            <div class="space">{{ item.judgeDate }}</div>
          </div>
          <label>經驗律師:</label>
          <div class="lawyer">
            <div v-for="arr in item.lawyers" :key="arr.id">
              <button
                class="lawyerbutton"
                v-b-modal.modal-1
                @click="detail(arr.id)"
              >
                {{ arr.name }}
              </button>
            </div>
          </div>
          <div class="content">
            {{ item.mainContent
            }}<button class="searchid" @click="showsearchid(item.id)">
              (點擊閱讀更多資料...)
            </button>
          </div>
        </div>
      </div>
      <div class="predict" v-if='this.$store.state.resultp.first!=""'>
        <h3>預測案由</h3>
        <button @click="turn(first)">
          {{ this.$store.state.resultp.first }}
        </button>
        <button @click="turn(second)">
          {{ this.$store.state.resultp.second }}
        </button>
        <button @click="turn(third)">
          {{ this.$store.state.resultp.third }}
        </button>
      </div>
    </div>
    <lawyer-modal :id="lawyerid"></lawyer-modal>
  </div>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";
import LawyerModal from "../components/LawyerModal.vue";

Vue.use(VueAxios, axios);

export default {
  name: "SearchResult",
  components: {
    LawyerModal,
  },
  computed: {
    results() {
      return this.$store.state.results;
    },
    first() {
      return this.$store.state.resultp.first;
    },
    second() {
      return this.$store.state.resultp.second;
    },
    third() {
      return this.$store.state.resultp.third;
    },
  },
  data() {
    return {
      eventDetail: {
        id: null,
      },
      lawyerid: null,
    };
  },
  methods: {
    detail(par) {
      this.lawyerid = par;
    },
    cancel() {
      document.querySelector(".blockdisplay").style.display = "none";
    },
    showsearchid(id) {
      axios.get("http://140.123.174.200/api/Search/" + id).then((resp) => {
        this.eventDetail = resp.data;
        console.log(resp.data);
      });
      document.querySelector(".blockdisplay").style.display = "flex";
    },
    turn(e) {
      console.log(e);
      axios
        .post("http://140.123.174.200/api/Search", {
          classification: e,
          searchQuery: this.$store.state.query,
        })
        .then((resp) => {
          console.log(resp.data);
          this.$store.state.results = resp.data.data;
        });
      //   }
    },
  },
};
</script>

<style scoped>
.lawyer {
  display: flex;

  flex-wrap: wrap;
}
.informationFirstLine {
  display: flex;
  justify-content: space-between;
  width: 25vw;
}
.close {
  border-radius: 50%;
  height: 50px;
  width: 50px;
  position: absolute;
  background-image: url(https://cdn-icons-png.flaticon.com/512/130/130877.png);
  background-size: cover;
  background-color: #fff;
  rotate: 40deg;
  margin-left: 86vw;
}
.close:hover {
  animation: cancel 2s infinite;
}
@keyframes cancel {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(359deg);
  }
}
.blockdisplay {
  background-color: rgb(252, 215, 160);
  width: 90vw;
  height: 80vh;
  position: fixed;
  transform: translateX(5vw);
  border-radius: 10px;
  margin-top: 10vh;
  z-index: 1;
  display: none;
}
.eventDetail {
  width: 80vw;
  height: 70vh;
  background: rgba(255, 255, 255, 0.3);

  padding: 30px;
  border: 1px solid rgba(255, 255, 255, 0.1);
  border-radius: 10px;
  position: fixed;
  transform: translateX(5vw);
  margin-top: 5vh;
  z-index: 1;
  overflow-y: scroll;

  padding: 2.5rem;
}

h3 {
  margin-bottom: 0.5rem;
}
.searchid {
  background-color: rgb(211, 211, 208);
  color: rgb(62, 84, 207);
  height: 10px;
  width: 170px;
  margin: 5px;
}
.information {
  display: flex;
}
.content {
  margin-top: 1.5rem;
}
.space {
  display: flex;
  justify-content: center;
  align-items: center;
  margin-right: 1rem;
  height: 5vh;
}

.lawyerbutton {
  height: 30px;
  background-color: rgb(29, 112, 105);
  font-size: 1rem;
}
.about {
  width: 100vw;
}
.data {
  margin: 2rem;
  background-color: rgb(211, 211, 208);
  padding: 1rem;
  border-radius: 10px;
}
.result {
  width: 100vw;
  background-color: rgb(105, 104, 103);

  top: 10vh;
  display: flex;
  justify-content: space-between;
  padding: 5vw;
}
.predict {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  margin-left: 10rem;
  background-color: rgb(255, 255, 255);
  padding: 0.5rem;
  height: 25vh;
  width: 200px;
  position: fixed;
  margin-left: 70vw;
  border-radius: 10px;
  margin-top: 7vh;
}
button {
  width: 130px;
  height: 50px;
  margin: 0.5rem;
  background-color: rgb(43, 43, 43);
  color: white;
  border: none;
  cursor: pointer;
}
.record {
  width: 60vw;
  margin-top: 3vh;
  
}
.loadinggif{
  margin: auto;
  width: 50%;
  padding: 10px;
}
</style>