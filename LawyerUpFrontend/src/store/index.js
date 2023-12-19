import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    resultp: {
      first: "",
      second: "",
      third: "",
    },
    results:undefined,
    query:null
  },
  getters: {
    // updateresult(state){
    //   return state.results.filter(results=>results)
    // }
  },
  mutations: {
    clearResultp(state){
      state.resultp.first = "";
      state.resultp.second = "";
      state.resultp.third = "";
    }
  },
  actions:{
    
  }
});
