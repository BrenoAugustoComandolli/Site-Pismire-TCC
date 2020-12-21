<template>
  <div id="cadastro">
        <h1 id="txt1">Que tipo de usuário você é?</h1>    
        <div id="divtrab">   
          <img src="../assets/empregado.png" alt="" width="100px" height="100px" id="usu"><br><br>
          <br><router-link to="/trabalhador" id="trabalhador" >Trabalhador</router-link><br><br><br>  
          <h3 id="pes">Pessoa física</h3> 
        </div> 
        <div id="divemp">    
          <img src="../assets/empresa.png" alt="" width="100px" height="100px" id="emp"><br><br> 
          <br><router-link to="/empresa" id="empresa">Empresa</router-link><br><br><br>
          <h3 id="pes1">Pessoa jurídica</h3>
        </div>
    </div>
</template>

<script>
export default {

}
</script>

<style>
#divtrab {
    float: left;
    margin-left: 550px;
    margin-top: 100px;
    color:  white;
}
#divemp {
    float: right;
    margin-right: 10px;
    margin-top: 100px;
    color: white;
}
#txt1 {
    margin-left: 580px;
    margin-top: 80px;
    margin-right: 30px;
    color: white;
}

#trabalhador {
    padding: 20px 20px;
    text-decoration: none;
    color: black;
    width: 300px;
    height: 200px;
    background: #C5BDFB;
    border: solid 1px black;
    border-radius: 25px;
}
#empresa {
    padding: 20px 30px;
    text-decoration: none;
    color: black;
    width: 300px;
    height: 200px;
    background: #C5BDFB;
    border: solid 1px black;
    border-radius: 25px;
}
*{
    margin-top: 0;
    margin-left: 0;
    margin-right: 0;
    margin: 0;
}

@media (max-width: 420px) {
   #cadastro {
       width: 420px;
       height: 500px;
   }
   #txt1 {
       margin-left: 20px;
       font-size: 20px;
   }
   #divtrab {
       margin-left: 30px;
   }
   
}
#divemp {
    float: right;
    margin-right: 10px;
    margin-top: 100px;
}

</style>