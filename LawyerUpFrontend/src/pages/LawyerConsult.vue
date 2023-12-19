<template>
  <div class="canvas">
    <section class="sec-03">
      <div class="container">
        <h3 class="section-title"><strong>律師諮詢的目的</strong></h3>
        <ul>
          <li>
            <div class="text-box sec-02-box1">
              <img
                src="https://www.lawchain.tw/images/icons/qa01.svg"
                alt="我的案件該找律師嗎?"
                srcset=""
              />
              <h3 class="info-title">
                <strong>我的案件</strong>
                該找律師嗎
              </h3>
            </div>
          </li>
          <li>
            <div class="text-box sec-02-box2">
              <img
                src="https://www.lawchain.tw/images/icons/qa02.svg"
                alt="專業律師回答"
                srcset=""
              />
              <h3 class="info-title">
                <strong>諮詢後</strong>
                確定要找律師
              </h3>
            </div>
          </li>
          <li>
            <div class="text-box sec-02-box3">
              <img
                src="https://www.lawchain.tw/images/icons/qa03.svg"
                alt="完成線上諮詢"
                srcset=""
              />
              <h3 class="info-title">
                <strong>LawyerUP</strong>
                搜索相關律師
              </h3>
            </div>
          </li>
        </ul>
      </div>
    </section>
    <section class="sec-01">
      <div class="container">
        <h2 class="main-title"><strong>到底該不該請律師？</strong></h2>
        <div class="content">
          <div class="image">
            <iframe
              width="840"
              height="500"
              src="https://www.youtube.com/embed/eBR0Hb9mPJg"
              title="YouTube video player"
              frameborder="0"
              allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
              allowfullscreen
            ></iframe>
          </div>
          <div class="text-box">
            <h3><strong>找律師</strong></h3>
            <br />
            <p>
              1. 甚麼時候該請律師?<br />
              2. 被告了一定要請律師嗎?<br />
              3. 免費法律諮詢?<br />
            </p>
          </div>
        </div>
      </div>
    </section>
    <section class="sec-04">
      <div class="container">
        <ul>
          <li>
            <div class="text-box sec-02-box1">
              <router-link to="/FreeLawyerConsult">
                <input
                  type="button"
                  value="免費律師諮詢"
                  name="按鈕名稱"
                  style="width: 500px; height: 100px"
                />
              </router-link>
            </div>
          </li>
          <li>
            <div class="text-box sec-02-box3">
              <router-link to="/FreeLawyerConsult">
                <input
                  type="button"
                  value="Premium線上諮詢"
                  name="按鈕名稱"
                  style="width: 500px; height: 100px"
                />
              </router-link>
            </div>
          </li>
        </ul>
      </div>
    </section>
  </div>
</template>
<script>
import { jarallax } from "jarallax";
import ScrollReveal from "scrollreveal";

export default {
  name: "Body",
  mounted() {
    jarallax(document.querySelectorAll(".jarallax"), {
      speed: 0.2,
    });
    ScrollReveal({
      reset: true,
      distance: "100px",
      duration: 2500,
      interval: 0,
      scale: 0.8,
    });
    ScrollReveal().reveal(".main-title", { delay: 100, origin: "left" });
    ScrollReveal().reveal(".sec-01 .image", { delay: 100, origin: "bottom" });
    ScrollReveal().reveal(".text-box", { delay: 100, origin: "right" });
    ScrollReveal().reveal(".sec-02-box1", {
      delay: 100,
      origin: "bottom",
      distance: "100px",
    });
    ScrollReveal().reveal(".sec-02-box2", {
      delay: 150,
      origin: "bottom",
      distance: "200px",
    });
    ScrollReveal().reveal(".sec-02-box3", {
      delay: 200,
      origin: "bottom",
      distance: "300px",
    });
    ScrollReveal().reveal(".media-info li", {
      delay: 100,
      origin: "top",
      interval: 200,
    });
  },
};
</script>

<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
.sec-01 {
  padding-bottom: 0vh;
}
.sec-02 {
  background: url(https://nypost.com/wp-content/uploads/sites/2/2020/05/supreme-court-2.jpg?quality=90&strip=all&w=1236&h=820&crop=1);
  height: 100vh;
  background-size: cover;
  background-attachment: fixed;
}
.sec-02 .content {
  display: inline-block;
  padding-left: 10vw;
  padding-bottom: 100vh;
}

.sec-02 .content .text-box {
  display: inline;
  align-content: center;
}
.canvas {
  background: rgb(150, 150, 150);
  height: 150vh;
  width: 100vw;
}
section {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 15vh 100px;
  color: red;
}
.container {
  display: flex;
  position: relative;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
.text-box img {
  display: inline-flex;
  position: relative;
  width: 90px;
  height: 80px;
}
.main-title {
  font-size: 4rem;
  margin-bottom: 3vh;
  margin-top: -10vh;
  color: rgb(153, 0, 0);
}
.content {
  position: relative;
  width: 100vw;
  display: flex;
  justify-content: center;
  align-items: center;
}
.content .image {
  position: relative;
  width: 900px;
  height: 600px;
  overflow: hidden;
}
.content .image img {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  object-fit: cover;
  border-radius: 10px;
  padding-left: 1rem;
  padding-right: 1rem;
}
.content .text-box {
  background: rgba(255, 255, 255, 0.1);
  backdrop-filter: blur(20px);
  padding: 50px;
  max-width: 400px;
  border: 1px solid rgba(255, 255, 255, 0.1);
  border-radius: 10px;
  transform: translate(-80px, 50px);
  color: rgb(153, 0, 0);
}
.content .text-box h3 {
  font-size: 2rem;
  margin-bottom: 5px;
  color: black;
}
.content .text-box p {
  font-size: 1.5rem;
  color: black;
}
.media-icons {
  margin-top: 100px;
}
.media-icons a {
  color: white;
  font-size: 2em;
  margin: 60px;
}
.section-title {
  font-size: 3em;
  margin-bottom: 80px;
  color: black;
}
.info-title {
  font-size: 1.8em;
  margin-bottom: 10px;
}
.sec-03 {
  background-color: rgb(255, 255, 255);
}
.sec-03 ul li {
  display: inline-block;
  align-content: center;
  padding: 30px;
  max-width: 400px;
}
.sec-04 {
  background-color: rgb(150, 150, 150);
  padding-top: 0vh;
}
.sec-04 ul li {
  display: inline-block;
  align-content: center;
  padding: 30px;
  max-width: 900px;
}
input {
  font-size: 3rem;
  border: 0;
  background-color: #003c9d;
  color: #fff;
  border-radius: 10px;
  cursor: pointer;
}

input:hover {
  color: #003c9d;
  background-color: #fff;
  border: 2px #003c9d solid;
}
</style>
