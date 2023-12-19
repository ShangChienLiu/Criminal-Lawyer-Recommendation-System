<template>
  <div class="pagination">
    <div class="sex">
      <select  id="select" v-model="input.page" v-on:change="GoTo"></select>
      <input type="checkbox" name="sex" v-model="input.sex" v-on:change="GoTo">
      <h5 for="sex">依性別排序</h5>
    </div>
    
    <div class="countyList">
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value=""  id="無" checked><label for="無">無</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="台北律師公會"  id="台北市"><label for="台北市">臺北市</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="基隆律師公會"  id="基隆市"><label for="基隆市">基隆市</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="桃園律師公會"  id="桃園市"><label for="桃園市">桃園市</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="台中律師公會"  id="台中市"><label for="台中市">臺中市</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="台南律師公會"  id="台南市"><label for="台南市">臺南市</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="高雄律師公會"  id="高雄市"><label for="高雄市">高雄市</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="新竹律師公會"  id="新竹縣"><label for="新竹縣">新竹縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="苗栗律師公會"  id="苗栗縣"><label for="苗栗縣">苗栗縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="彰化律師公會"  id="彰化縣"><label for="彰化縣">彰化縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="南投律師公會"  id="南投縣"><label for="南投縣">南投縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="雲林律師公會"  id="雲林縣"><label for="雲林縣">雲林縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="嘉義律師公會"  id="嘉義縣"><label for="嘉義縣">嘉義縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="屏東律師公會"  id="屏東縣"><label for="屏東縣">屏東縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="宜蘭律師公會"  id="宜蘭縣"><label for="宜蘭縣">宜蘭縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="花蓮律師公會"  id="花蓮縣"><label for="花蓮縣">花蓮縣</label></div>
            <div class="county"><input type="radio" name="coutyOption" v-on:change="GoTo" v-model="input.guild"  value="台東律師公會"  id="台東縣"><label for="台東縣">臺東縣</label></div>
        </div>
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
        name:null,
        guild:null
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
      this.$emit('changeurll',{page:this.input.page,sex:this.input.sex,guild:this.input.guild})
    },
    
  }
};
</script>

<style scoped>
.sex{
  display: flex;
  height: 50px;
}
.pagination{
  width: 100%;
  height: 30vh;
  margin-left: 1vw;
  display: flex;
  flex-direction: column;
  margin-bottom: 5rem;
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
.countyList{
    display: flex;
    flex-wrap: wrap;
    width: 60vw;
    margin: 0.25rem;
    padding-left: 2rem;
    margin-bottom: 4rem;
}
input[type=radio] {
    visibility:hidden;
}
.county{
    height: 70px;
}
label {
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    background-color: #fff;
    width: 130px;
    height: 50px;
    margin: 0.5rem;
    border-radius: 5px;
    font-weight: 600;
    font-size: 1rem;
}
input:checked + label {
    background-color: rgb(79, 176, 255);
}
label:hover{
    background-color: rgb(189, 225, 255)
}
</style>
