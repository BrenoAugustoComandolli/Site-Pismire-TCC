<template>
  <div id="app">
    <div id="m">
      <button id="menu" img="/assets/menu.png" @click="mostrar()"></button>
    </div>
    <div id="cab">
      <router-link to="/" id="home">Home</router-link> 
      <router-link to="/faleconosco" id="fale">Fale Conosco</router-link>
      <router-link to="/ajuda" id="ajuda">Ajuda</router-link>   
      <router-link to="/quemsomos" id="quem">Quem Somos</router-link> 
      <a href="Pismire - Setup.msi" id="download">Download</a>
      <router-link to="/cadastro" id="cadastro">Cadastre-se</router-link> 
    </div>
    <div id="cabe">      
       <nav id="nav">
         <ul>
          <router-link to="/" id="homec" @click.native="mostrar()">Home</router-link> <br><br>
          <router-link to="/faleconosco" id="falec" @click.native="mostrar()">Fale Conosco</router-link> <br><br>
          <router-link to="/ajuda" id="ajudac" @click.native="mostrar()" >Ajuda</router-link>  <br><br>
          <router-link to="/quemsomos" id="quemc" @click.native="mostrar()" >Quem Somos</router-link> <br><br>       
          <a href="Pismire - Setup.msi" id="downloadc">Download</a><br><br>
          <router-link to="/cadastro" id="cadastroc" @click.native="mostrar()">Cadastre-se</router-link>
         </ul>
      </nav>         
    </div>
    <router-view/>
  </div>
</template>
<script>
export default {
  name: 'App',
  data: function() {
    return {mostra: false}
  },
  methods: {
    mostrar: function() {
            let cabe = document.querySelector("#cabe")     
            this.mostra = !this.mostra
            if (this.mostra){
                cabe.style.display = "inline";             
            } else {
                cabe.style.display = "none";
            }

        },  
    }
  }

</script>
<style>

#app {
  font-family:  Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;       /*Padrao Pagina*/
  text-align: center;
  background: #292929;
  width: 100%;
  height: 799px;
}

#cabe {
  margin-top: -100px;
  width: 200px;
  height: 500px;
  
}

#cab { 
  width: 100%;
  height: 80px;               
  background: #666692;
} 

#cabe {
  display: none;
}

#ajuda {
  float: right;
  width: 100px;
  margin-top: 28px;             /*Rota Ajuda*/
  margin-right: 0px;
}

#quem {
  float: right;
  width: 150px;                  /*Rota Quem Somos*/
  margin-top: 28px;
  margin-right: -10px;
}

#fale {
  float: right;
  width: -100px;
  margin-top: 28px;               /*Rota Fale Conosco*/
  margin-right: 0px;
}

#home {
  
  width: 100px;
  margin-top: 28px;               /*Rota Home*/
  float: right;
}

#cadastro {
  float: left;
  width: -100px;                  /*Rota Cadastro*/
  margin-top: 28px;
  margin-left: 10px;
}

#download {
  float: left;
  width: -100px;
  margin-top: 28px;                /*Rota Download*/
  margin-left: 20px;
}

*{
    margin-top: 0;
    margin-left: 0;                   /*padrao da pagina*/
    margin-right: 0;
    margin: 0;
}

#cab a {
  font-weight: bold;
  color: white;
  font-size: 20px;
  text-decoration: none;
}

#menu {
  display: none;
}
#nav {
  display: none;
  
}
#nav #ul {
  position: absolute;
  visibility: hidden;
  
}
@media (max-width: 420px) {  
    #app{
      width: 450px;
      height: 700px;
      background: #1d1d1d;
    }
    
    #cab {
      display: none;
    }
    #m {
      width: 450px;
      height: 100px;
      background: #666692;
    }
    #menu {
      display: inline;
      background-color: transparent;
      background-image: url('assets/menu.png');
      float: left;
      margin-top: 30px;
      margin-left: 30px;
      border: none;
      width: 50px; 
      height: 50px;
    } 

   #nav {
    width: 220px;
    background: #666692;
    display: flex;
    
  }
  #nav ul {
    margin: 0;
    margin-top: 1px;
    padding: 20px;
    width: 160px;
    height: 250px;
    background: #666692;
    position: absolute;
    overflow: hidden;
    z-index:999;
    
  }
  #cabe a {
    color: white;
    font-size: 20px;
    text-decoration: none;
    padding: 5px;
  }
  #homec {
    margin-left: -70px;
  }
  #ajudac{
    margin-left: -70px;
  }
  #downloadc {
    margin-left: -30px;
  }
  #cadastroc {
    margin-left: -20px;
  }

}

</style>
