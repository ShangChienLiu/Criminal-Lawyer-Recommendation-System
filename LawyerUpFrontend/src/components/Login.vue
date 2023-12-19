<template>
  <b-modal id="modal-2" title="註冊/登入">
    <div class="form-floating mb-3">
      <label for="floatingInput">Email</label>
      <input
        type="email"
        class="form-control"
        id="floatingInput"
        placeholder="name@example.com"
      />
    </div>
    <div class="form-floating">
      <label for="floatingPassword">Password</label>
      <input
        type="password"
        class="form-control"
        id="floatingPassword"
        placeholder="Password"
      />
    </div>
    <br />
    <p v-b-modal.modal-dialog><a class="click" title="點我註冊">點我註冊</a></p>
    <enroll></enroll>
  </b-modal>
</template>

<script>
import Enroll from "./Enroll.vue";
export default {
  name: "Login",
  components: {
    Enroll,
  },
};
</script>

<style scooped>
a.click {
  color: #007bff;
}
</style>