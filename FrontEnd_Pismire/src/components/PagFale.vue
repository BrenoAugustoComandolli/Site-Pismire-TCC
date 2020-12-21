<template>
  <div id="PagFale">
      <div id="left">
          <h3>Você pode entrar em contato conosco <br>
            através do e-mail ou pelas nossas redes sociais</h3> <br><br><br><br><br>
            <img src="../assets/gmail1.png" alt="" width="35px" height="35px" id="logog">
            <h4 id="gmail">central.pismire@gmail.com</h4><br>
            <img src="../assets/twitter.png" alt="" width="37px" height="37px" id="logot" @click="redtwitter">
            <h4 id="twitter" @click="redtwitter">@central.pismire</h4><br>
            <img src="../assets/insta.png" alt="" width="35px" height="35px" id="logoi" @click="redinsta">
            <h4 id="insta" @click="redinsta">@central.pismire</h4>
            <img src="../assets/facebook (1).png" alt="" width="35px" height="35px" id="face" @click="redirect">
            <h4 id="facebook" @click="redirect">@PismireApp</h4>
      </div>
      <div id="faleright">
          <img src="../assets/FotoSite5.png" alt="" width="700px" height="420px" id="faleconoscoimg">
      </div>
  </div>
</template>

<script>
export default {
    data:function() {
        return {

        }
    }, methods: {
        redirect: function() {
            window.location.href= "https://www.facebook.com/PismireApp/";
        },
        redtwitter: function() {
            window.location.href = "https://twitter.com/CentralPismire";
        },
        redinsta: function() {
            window.location.href = "https://www.instagram.com/central.pismire/?hl=pt-br";
        }
        
    }
}
</script>

<style>

#PagFale{
    color: white;
}

#left {
    font-size: 20px;
    margin-top: 80px;
    float: left;
    text-align: left;
    margin-left: 100px;
}
#gmail {
    font-size: 25px;
    margin-left: 45px;
    margin-top: -36px;
}
#logot {
    margin-top: 0px;
}
#twitter {
    font-size: 25px;
    margin-left: 40px;
    margin-top: -38px;
}

#logoi {
    margin-top: 4px;
}

#insta {
    font-size: 25px;
    margin-left: 40px;
    margin-top: -37px;
}

#face {
    margin-top: 26px;
    margin-left: -2px;
}

#facebook {
    font-size: 25px;
    margin-left: 40px;
    margin-top: -37px;
}

#faleright {
    float: right;
    margin-right: 80px;
    margin-top: 120px;
}

@media(max-width: 420px) {
   
   #left {
    margin-top: 50px;
    float: left;
    text-align: left;
    margin-left: 50px;
    font-size: 14px;
}
#logog{
    margin-top: -90px;
    margin-left: 0px;
}

#gmail {
    margin-left: 45px;
    margin-top: -38px;
}
#logot {
    margin-top: -8px;
}
#twitter {
    margin-left: 40px;
    margin-top: -35px;
}

#logoi {
    margin-top: -5px;
}

#insta {
    margin-left: 40px;
    margin-top: -34px;
}

#face {
    margin-top: 10px;
    margin-left: -2px;
}

#facebook {
    margin-left: 40px;
    margin-top: -35px;
}

#faleright {
    margin-right: 0px;
    margin-top: 0px;
} 
#faleconoscoimg {
    width: 300px;
    height: 300px;
    margin-right: 80px;
}
}
</style>