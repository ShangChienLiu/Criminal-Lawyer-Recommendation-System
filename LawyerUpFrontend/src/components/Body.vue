<template>
  <div class="canvas">
    <section class="sec-03">
      <div class="container">
        <h3 class="section-title">免費法律諮詢</h3>
        <div class="content">
          <div class="media-info">
            <li>
              <a
                href="https://sec.gov.taipei/News_Content.aspx?n=224402C613AE51F3&sms=10B6E6F8F525E234&s=9FCDE8146D4D8DA8"
                >台北市政府法律諮詢服務櫃檯</a
              >
            </li>
            <li>
              <a
                href="https://legal.tycg.gov.tw/home.jsp?id=295&parentpath=0,142,254"
                >桃園市政府法律諮詢中心</a
              >
            </li>
            <li>
              <a href="https://legal-aid.taichung.gov.tw/News/ContentView?PID=3"
                >台中市政府市政大樓10樓</a
              >
            </li>
            <li>
              <a href="https://laf.chiayi.gov.tw/">嘉義市政府一樓法扶諮詢室</a>
            </li>
            <li>
              <router-link to="/FreeLawyerConsult"> 查看更多 </router-link> >
            </li>
          </div>
          <div class="jarallax">
            <div class="image">
              <img
                src="https://th.bing.com/th/id/OIP.rrpOGPeGn3AJlPQV3G7yHQHaEC?pid=ImgDet&w=825&h=450&rs=1"
              />
            </div>
          </div>
        </div>
      </div>
    </section>
    <section class="sec-01">
      <div class="container">
        <h2 class="main-title">如何找律師呢?</h2>
        <div class="content">
          <div class="image">
            <img
              src="https://scontent.ftpe7-1.fna.fbcdn.net/v/t1.15752-9/278880434_387846013352756_4895846533364110658_n.png?_nc_cat=110&ccb=1-6&_nc_sid=ae9488&_nc_ohc=d5FKqAlodxAAX-F3ANv&_nc_ht=scontent.ftpe7-1.fna&oh=03_AVLCKKf1DUrzYSohuVX4OdpMJPgNhdx-7c_85ugiU-gGnQ&oe=629F62B5"
              alt=""
            />
          </div>
          <div class="text-box">
            <h3>找律師</h3>
            <br />
            <p>
              第一步：<br />
              輸入律師姓名、案件類型或關鍵字。<br />
              第二步：<br />
              查看判決書，選擇推薦律師。
            </p>
          </div>
        </div>
        <!-- <div class="media-icons">
          <a href="#" class="icon"><i class="fab fa-facebook"></i></a>
          <a href="#" class="icon"><i class="fab fa-instagram"></i></a>
          <a href="#" class="icon"><i class="fab fa-twitter"></i></a>
          <a href="#" class="icon"><i class="fab fa-youtube"></i></a>
        </div> -->
      </div>
    </section>
    <section class="sec-02">
      <div class="content">
        <div class="text-box sec-02-box1">
          <h4 class="info-title">創新、獨家的搜尋方式</h4>
          <p>
            透過關鍵字搜索，將會找到類似的案件，如未搜索到結果，可以點擊右方採用Bert模型訓練出的參考案由進行查找。
          </p>
        </div>
        <div class="text-box sec-02-box2">
          <h4 class="info-title">詳細的判決書資訊</h4>
          <p>
            網站收錄了近三年嘉義市刑法案件的判決書14,000筆，豐富的判決讓使用者查詢。
          </p>
        </div>
        <div class="text-box sec-02-box3">
          <h4 class="info-title">豐富的律師資訊</h4>
          <p>
            資料庫含括了11,000筆全台灣的律師資訊，讓找律師變得更簡單。
            <br />
          </p>
        </div>
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
  font-family: "Poppins", sans-serif;
}
.sec-02 {
  background: url(https://nypost.com/wp-content/uploads/sites/2/2020/05/supreme-court-2.jpg?quality=90&strip=all&w=1236&h=820&crop=1);
  height: 100vh;
  background-size: cover;
  background-attachment: fixed;
}
.sec-02 .content {
  display: flex;
  padding-left: 10vw;
  padding-bottom: 10vh;
}
.sec-02 .content .text-box {
  margin: 2rem;
}
.canvas {
  background: rgb(5, 5, 5);
  height: 290vh;
  width: 100vw;
}
section {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 15vh 100px;
  color: white;
}
.container {
  display: flex;
  position: relative;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
.main-title {
  font-size: 4rem;
  margin-bottom: 3vh;
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
  width: 800px;
  height: 400px;
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
  padding: 40px;
  max-width: 400px;
  border: 1px solid rgba(255, 255, 255, 0.1);
  border-radius: 10px;
  transform: translate(-80px, 50px);
}
content .text-box h3 {
  font-size: 2rem;
  margin-bottom: 10px;
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
}
.info-title {
  font-size: 1.8em;
  margin-bottom: 10px;
}
.info {
  width: 30vw;
  margin-left: 5vw;
}
.media-info {
  width: 400px;
  margin-left: 50px;
}
.media-info li {
  list-style: none;
  font-size: 1.4em;
}
.media-info li a {
  color: white;
  text-decoration: none;
}
.media-info li:not(:last-child) {
  margin-bottom: 50px;
}
.media-info li:nth-child(1),
.media-info li:nth-child(5) {
  padding-left: 10vw;
}
.media-info li:nth-child(2),
.media-info li:nth-child(4) {
  padding-left: 4vw;
}
.sec-03 {
  background-color: rgb(65, 65, 65);
}
</style>

