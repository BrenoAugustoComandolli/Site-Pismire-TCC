<template>
  <div>
     <div id="SlidesPagina">
      <section class="galeria">
        <img class="fotoslide" src="../assets/Slide2-Site.png" width="100%" height="719px" margin-top="120px" id="TransicaoImagem" position="relative"/>
        <img class="fotoslide" src="../assets/Slide4-Site.png" width="100%" height="719px" margin-top="120px" id="TransicaoImagem" position="relative"/>
        <img class="fotoslide" src="../assets/Slide3-Site.png" width="100%" height="719px" margin-top="120px" id="TransicaoImagem" position="relative"/>
        <img class="fotoslide" src="../assets/Slide1-Site.png" width="100%" height="719px" margin-top="120px" id="TransicaoImagem" position="relative"/>
        <img class="fotoslide" src="../assets/Slide5-Site.png" width="100%" height="719px" margin-top="120px" id="TransicaoImagem" position="relative"/>
      </section>
    </div>
  </div>  
</template>

<script>
export default {

}
</script>

<style>
#SlidePagina{
  background-color: #292929;
}

#galeria{
  margin: 80px auto;
  width: 100%;
  height: 720px;
  position: relative;
  overflow: hidden;
}
#TransicaoImagem{
  position: absolute;
  opacity: 0;
  animation-name: animacao;
  animation-duration: 35s;
  animation-iteration-count: infinite;
  margin-left: -50%;
}

@keyframes animacao {
  25%{
    opacity: 1;
    transform: scale(1);
  }
  50%{
    opacity: 0;
  }
}

#TransicaoImagem:nth-child(1) {
  animation-delay: 1s;
}
#TransicaoImagem:nth-child(2) {
  animation-delay: 7s;
}
#TransicaoImagem:nth-child(3) {
  animation-delay: 14s;
}
#TransicaoImagem:nth-child(4) {
  animation-delay: 21s;
}
#TransicaoImagem:nth-child(5) {
  animation-delay: 28s;
}

@media(max-width: 420px) {
  #div2{
    margin: 0px;
    padding: 0px;
  }

  #galeria{
  margin: 80px auto;
  width: 700px;
  height: 700px;
  position: relative;
  overflow: hidden;
}
#TransicaoImagem{
  margin-top: 140px;
  width: 477px;
  height: 320px;
  position: absolute;
  opacity: 0;
  animation-name: animacao;
  animation-duration: 35s;
  animation-iteration-count: infinite;
  margin-left: -70%;
}
}
</style>