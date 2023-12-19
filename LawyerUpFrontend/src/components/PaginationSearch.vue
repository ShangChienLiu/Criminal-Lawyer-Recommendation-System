<template>
  <div class="pagination">
    <select  id="select" v-model="input.page" v-on:change="GoTo"></select>
    <input type="checkbox" name="sex" v-model="input.sex" v-on:change="GoTo">
    <label for="sex">依性別排序</label>
  </div>
</template>

<script>
import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";

Vue.use(VueAxios, axios);

export default {
  name: "Pagination",
  data(){
    return{
      input:{
        page:null,
        sex:null,
        name:null
      }
    }
  },
  mounted() {
    var count;
    Vue.axios.get("http://140.123.174.200/api/Lawyer").then((resp) => {
      this.count = resp.data.pageCount;
      count = resp.data.pageCount;

      const container = document.getElementById("select");

      for (var i = 1; i <= count - 0; i++) {
        var options = document.createElement("option");
        options.value = i;
        options.innerHTML = i;
        container.appendChild(options);
      }
    });
  },
  methods:{
     GoTo(){
      this.$emit('changeurll',{page:this.input.page,sex:this.input.sex})
    },
    
  }
};
</script>

<style scoped>
.pagination{
  width: 100%;
  height: 40px;
  margin-left: 1vw;
}

select {
  height: 30px;
  width: 140px;
  border-radius: 7px;
  margin-right: 2rem;
  background-color: #4d5061;
  color: white;
  padding-left: 10px;
}

</style>
