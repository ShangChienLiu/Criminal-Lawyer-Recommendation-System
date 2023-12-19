<template>
  <b-modal id="modal-1" title="律師資料" ok-only>
    <table class="table">
      <tr>
        <td>姓名</td>
        <td>{{ response.name }}</td>
      </tr>
      <tr>
        <td>律師證號</td>
        <td>{{ response.now_lic_no }}</td>
      </tr>
      <tr>
        <td>性別</td>
        <td>{{ response.sex }}</td>
      </tr>
      <tr>
        <td>公會</td>
        <td>{{ response.guild_name }}</td>
      </tr>
      <tr>
        <td>事務所</td>
        <td>{{ response.office }}</td>
      </tr>
      <tr>
        <td>Email</td>
        <td>{{ response.email }}</td>
      </tr>
      <tr>
        <td>電話</td>
        <td>{{ response.tel }}</td>
      </tr>
      <tr>
        <td>地址</td>
        <td>{{ response.address }}</td>
      </tr>
      <tr>
        <td id="casehistory">參與判決經驗</td>
        <td>
          <table class="table-sm">
            <thead>
              <td><b>案由</b></td>
              <td><b>次數</b></td>
            </thead>
            <tbody>
              <tr v-for="(value, name) in response.caseHistories" :key="name">
                <td width="80%">{{name}}</td>
                <td width="20%" align="right">{{value}}</td>
              </tr>
            </tbody>
          </table>
        </td>
      </tr>
    </table>
  </b-modal>
</template>

<script>
import axios from "axios";

export default {
  name: "LawyerModal",
  props: {
    id: String,
  },
  data() {
    return {
      response: this.getData(this.id),
      caseHistoriesStr:undefined
    };
  },
  watch: {
    id: {
      immediate: true,
      handler(val) {
        this.getData(val);
      },
    },
  },
  methods: {
    getData(id) {
      if (id != undefined) {
        axios
          .get("http://140.123.174.200/api/Lawyer/" + id)
          .then((resp) => {
            console.log(resp.data);
            this.response = resp.data;
            console.log()
            this.caseHistoriesStr = this.caseHistories(resp.data.caseHistories);
          })
          .catch((err) => {
            console.log(err);
          });
      }
    },
    caseHistories(json){
      let string = "";
      if(json == null){
        string = "無相關資料";
      }else{
        Object.keys(json).forEach(key => {
          string += key + "&emsp;" + json[key] +"<br>";
        });
      }
      return string;
    },
    
  }
};
</script>

<style scoped>
#casehistory{
  vertical-align: top;
}
</style>