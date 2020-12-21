<template>
  <div id="div5">
      <div id="preencha">
        <h2>Preencha as informações abaixo </h2>
      </div>
      <div id="lbls">
      <label id="NomeEmp">Nome: </label>
      <input type="text" @click="pegarLogLat" id="txtNomeEmp" v-model="nome"/><br>
      <label id="FoneEmp">Telefone: </label>
      <input type="text" v-mask = " '(##)####-####' " id="txtFoneEmp" v-model="telefone" /><br>
      <label id="emailEmp">E-mail: </label>
      <input type="text" id="txtemailEmp" v-model="email"/><br>    
       <label id="confEmp">Confirme o e-mail: </label>  
      <input type="text" id="txtconfEmp" v-model="confEmail"/><br>
      <label id="senhaEmp">Senha: </label>
      <input type="password" id="txtSenhaEmp" v-model="senha"/><br>
      <label id="senhaconftEmp">Confirme sua senha: </label>
      <input type="password" id="confSenhaEmp" v-model="confSenha"><br>
          <button @click="salvar" id="btClickEmp">Confirmar</button>
      </div>
      <div id="imgEmp">
          <img src="../assets/empresa.png" alt="" width="350px" height="350px" id="imgemp">
      </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      mask: "(##) ####-####",
      telefone: "4140028922"
    };
  }
};
</script>

<script>
const axios = require('axios')
export default {
data: function() {
    return {
      nome: '',
      telefone: '',
      email: '',
      confEmail: '',   // Variaveis utilizado para pegar informações dos inputs do HTML5
      senha: '',
      confSenha: '',
      latitude: "",
      longitude: "",
    }
  }, methods: {
       pegarLogLat: function(){
        navigator.geolocation.getCurrentPosition(pos => {
        this.latitude = pos.coords.latitude;
        this.longitude = pos.coords.longitude;
        })
    },
    salvar: function() {//Função do botão!!
    navigator.geolocation.getCurrentPosition(pos => {
      this.latitude = pos.coords.latitude;
      this.longitude = pos.coords.longitude;
      })
      if(this.nome != '') {//Validação campo nome  
        if(this.telefone != '') { // validação campo telefone
          if(this.email != '') {//validação campo email
            if(this.senha != '') {//validação campo senha
               if(this.email == this.confEmail) { //comparação de emails !!
                  document.getElementById('txtconfEmp').style.borderColor = ''
                    if( this.senha == this.confSenha) { //comparação de senhas !!
                          axios.post("http://localhost:61551/api/Trabalhador", {
                          nomeUsuario: this.nome,
                          e_mailUsuario: this.email,
                          senhaUsuario: this.senha,
                          tipoUsuario: false, 
                          telefoneUsuario: this.telefone,
                          latitudeUsuario: this.latitude,
                          longitudeUsuario: this.longitude
                      }).then(resp => alert(resp.data))       //Cadastro de usuario no  banco de dados!!                                                             //Banco de dados !!
                        this.nome      = clearImmediate();
                        this.telefone  = clearImmediate();
                        this.email     = clearImmediate();
                        this.confEmail = clearImmediate();
                        this.senha     = clearImmediate();
                        this.confSenha = clearImmediate();
                        document.getElementById('txtNomeEmp').style.borderColor   = "";  
                        document.getElementById('txtFoneEmp').style.borderColor   = "";
                        document.getElementById('txtSenhaEmp').style.borderColor  = "";  
                        document.getElementById('txtconfEmp').style.borderColor   = "";
                        document.getElementById('confSenhaEmp').style.borderColor = "";  
                        document.getElementById('txtemailEmp').style.borderColor  = ""; 
                    }  else {
                      alert("Sua senha não é compatível!");
                    }
              } else {
                alert("Seu e-mail não é compatível!");         
              }
            } else {
               alert("O campo senha está vazio, por favor preencha sua senha !!")  
            }
          } else {
            alert("O campo e-mail está vazio, por favor digite seu e-mail !!")
          }
        } else {
          alert("O campo telefone está vazio, por favor digite seu telefone !!")
        }
    } else {
      alert("O campo nome está vazio, por favor digite seu nome !!")
    }
    } 
    }, mounted() {
        axios.get("http://localhost:61551/api/Email").then(e_mailUsuario => this.emails = e_mailUsuario.data)
    }
}
</script>

<style>
#preencha {
  margin-top: 50px;
  color: white;
}
#lbls {
  float: left;
  margin-left: 230px;
  margin-top: 100px;
  color: white;
}

#txtEst {
  width: 170px;
}

#imgemp {
  margin-top: 80px;
  margin-right: -10px;
}

#txtNomeEmp {
  width: 401px;
  background-color: #414141;
  color: white;
  border-style: none;
}
#txtFoneEmp {
  margin-top: 10px;
  width: 382.5px;
  background-color: #414141;
  color: white;
  border-style: none;
}
#txtemailEmp {
  margin-top: 10px;
  width: 398.5px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#txtconfEmp {
  margin-top: 10px;
  width: 317px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#txtSenhaEmp {
  margin-top: 10px;
  width: 398px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#confSenhaEmp {
  margin-top: 10px;
  width: 301px; 
  background-color: #414141;
  color: white;
  border-style: none;
}
*{
  padding: 0;
  margin: 0;
}

#btClickEmp {
    margin-top: 40px;
    text-decoration: none;
    color: black;
    width: 150px;
    height: 50px;
    background: #C5BDFB;
    border: solid 1px black;
    border-radius: 10px;
}
input[type=number]::-webkit-inner-spin-button,
    input[type=number]::-webkit-outer-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }

@media(max-width: 420px) {
  #preencha{
    margin-left: 10px;
  }
  #imgEmp {
    margin-top: -350px;
  }
  #imgemp {
    float: right;
    margin-top: -440px;
    margin-left: 180px;
    margin-right: 150px;
    width: 150px;
    height: 150px;
  }

  #lbls {
    float: left;
    margin-top: 250px;
    margin-left: 230px;
  }
  #NomeEmp {
    margin-left: -200px;
  }
  #txtNomeEmp {
    width: 315px;
    margin-left: 0px;
    margin-right: 0px;
    }
  #FoneEmp {
    margin-left: -200px;
  }
  #txtFoneEmp{
    width: 300px;
  }
  #emailEmp {
    margin-left: -200px;
  }
  #txtemailEmp {
    width: 316px;
  }
  #confEmp {
    margin-left: -200px;
  }
  #txtconfEmp {
    width: 233px;
  }
  #senhaEmp {
    margin-left: -200px;
  }
  #txtSenhaEmp {
    width: 318px;
  }
  #senhaconftEmp {
    margin-left: -200px;
  }
  #confSenhaEmp{
    width: 221px;
  }
  #btClickEmp{
    margin-left: -170px;
    margin-top: 30px;
    text-decoration: none;
    color: black;
    width: 150px;
    height: 50px;
    background: #C5BDFB;
    border: solid 1px black;
    border-radius: 10px;
  }
input[type=number]::-webkit-inner-spin-button,
    input[type=number]::-webkit-outer-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }
}
</style>