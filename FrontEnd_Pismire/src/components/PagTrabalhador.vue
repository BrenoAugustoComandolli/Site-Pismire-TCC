<template>
  <div id="div4">
    <div id="txt">
      <h2>Preencha as informações abaixo</h2>
    </div>
    <div id="labels">
      <label id="Name">Nome: </label>
      <input type="text" @click="pegarLogLat" id="txtName" v-model="nome" /> <br />
      <label id="Fone">Telefone: </label>
      <input type="text" v-mask = " '(##)####-####' " id="txtFone" v-model="telefone" /><br /> 
      <label id="email">E-mail: </label>
      <input type="text" id="txtemail" v-model="email" /><br />
      <label id="confe">Confirme o e-mail: </label>
      <input type="text" id="txtconf" v-model="confEmail" /> <br />
      <label id="senha">Senha: </label>
      <input type="password" id="txtSenha" v-model="senha" /> <br />
      <label id="senhaconft">Confirme sua senha: </label>
      <input type="password" id="confSenha" v-model="confSenha" /> <br />
      <button id="btClick"   @click="salvar">Confirmar</button>
    </div>
    <div id="imgcara">
      <img src="../assets/empregado.png" alt width="350px" height="350px" id="cara" />
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
const axios = require("axios");

export default {
  data: function() {
    return {
      nome: "",
      telefone: "",
      email: "",
      confEmail: "",
      senha: "",
      confSenha: "",
      latitude: "",
      longitude: "",
    };
  },
  
  methods: {
    pegarLogLat: function(){
    navigator.geolocation.getCurrentPosition(pos => {
        this.latitude = pos.coords.latitude;
        this.longitude = pos.coords.longitude;
        })
    },
    salvar: function() {
      if (this.nome != "") {//Validação campo nome
        if (this.telefone != "") {// validação campo telefone
          if (this.email != "") {//validação campo email
            if (this.senha != "") {//validação campo senha
              if (this.email == this.confEmail) {//comparação de emails !!
                document.getElementById("txtconf").style.borderColor = "";
                if (this.senha == this.confSenha) {//comparação de senhas !!
                  axios.post("http://localhost:61551/api/Trabalhador", {
                      nomeUsuario: this.nome,
                      e_mailUsuario: this.email,
                      senhaUsuario: this.senha,
                      tipoUsuario: true,
                      telefoneUsuario: this.telefone,
                      latitudeUsuario: this.latitude,
                      longitudeUsuario: this.longitude
                    })
                    .then(resp => alert(resp.data)); //Cadastro de usuario no Banco de dados!!
                  this.nome      = clearImmediate();
                  this.telefone  = clearImmediate();
                  this.email     = clearImmediate();
                  this.confEmail = clearImmediate();
                  this.senha     = clearImmediate();
                  this.confSenha = clearImmediate();
                  document.getElementById("txtName").style.borderColor   = "";
                  document.getElementById("txtFone").style.borderColor   = "";
                  document.getElementById("txtSenha").style.borderColor  = "";
                  document.getElementById("txtconf").style.borderColor   = "";
                  document.getElementById("confSenha").style.borderColor = "";
                  document.getElementById("txtemail").style.borderColor  = "";
                } else {
                  alert("Sua senha não é compatível!");                                                                     
                }
              } else {
                alert("Seu e-mail não é compatível!");            
              }
            } else {
              alert(
                "O campo senha está vazio, por favor preencha sua senha !!"
              );
            }
          } else {
            alert("O campo e-mail está vazio, por favor preencha seu e-mail !!");
          }
        } else {
          alert(
            "O campo telefone está vazio, por favor preencha seu telefone !!"
          );
        }
      } else {
        alert("O campo nome está vazio, por favor preencha seu nome !!");
      }
    }
  },
  mounted() {}
};

</script>

<style>

#div4 {
  color: black;
}
#txt {
  margin-top: 50px;
  color: white;
}

#labels {
  float: left;
  margin-top: 100px;
  margin-left: 230px;
  color: white;
}

#imgcara {
  float: right;
  margin-top: 90px;
  margin-right: 350px;
}

#cara {
  margin-top: -30px;
}

#txtName {
  margin-top: 20px;
  width: 383px;
  background-color: #414141;
  color: white;
  border-style: none;
}
#txtFone {
  margin-top: 10px;
  width: 366px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#txtemail {
  margin-top: 10px;
  width: 380px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#txtconf {
  margin-top: 10px;
  width: 300px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#txtSenha {
  margin-top: 10px;
  width: 380px;
  background-color: #414141;
  color: white;
  border-style: none;
}

#confSenha {
  margin-top: 10px;
  width: 280px;
  background-color: #414141;
  color: white;
  border-style: none;             
}
input[type=number]::-webkit-inner-spin-button,
    input[type=number]::-webkit-outer-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }

#btClick {
  margin-top: 40px;
  text-decoration: none;
  text-align: center;
  color: black;
  width: 150px;
  height: 50px;
  background: #c5bdfb;
  border: solid 1px black;
  border-radius: 10px;
}

@media (max-width: 420px) {
input[type=number]::-webkit-inner-spin-button,
    input[type=number]::-webkit-outer-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }
  #txt {
    font-size: 15px;
    margin-left: 10px;
  }
  #imgcara {
    margin-top: -415px;
  }
  #cara {
    width: 150px;
    height: 150px;
    margin-left: 180px;
    margin-right: -100px;
    margin-top: 0px;
  }
  #labels {
    margin-top: 180px;
    margin-left: 165px;
  }
  #Name {
    margin-left: -120px;
  }
  #txtName {
    width: 291px;
  }
  #Fone {
    margin-left: -120px;
  }
  #txtFone {
    width: 274px;
  }

  #email {
    margin-left: -120px;
  }
  #txtemail {
    width: 292px;
  }
  #confe {
    margin-left: -120px;
  }
  #txtconf {
    width: 208px;
  }
  #senha {
    margin-left: -120px;
  }
  #txtSenha {
    width: 292px;
  }
  #senhaconft {
    margin-left: -120px;
  }
  #confSenha {
    width: 194px;
  }
  #btClick {
    margin-top: 30px;
    text-decoration: none;
    text-align: center;
    color: black;
    width: 150px;
    height: 40px;
    background: #c5bdfb;
    border: solid 1px black;
    border-radius: 10px;
    margin-left: -120px;
  }
}
</style>