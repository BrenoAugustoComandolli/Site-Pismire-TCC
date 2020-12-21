<template>
  <div id="pagajuda">
      <h3 id="h3t">Estamos aqui para ajudar, envie sua duvida e seu e-mail que  
        entraremos em contato o mais rápido possível!</h3><br><br><br><br>
      <h1>Como podemos te ajudar?</h1><br><br>
    <form @submit.prevent="sendEmail" id="form">
        <input type="text" placeholder="Pergunta, dúvida, denúncias, etc..." id="inputajuda" name="message_html" v-model="message"/><br><br>
        <label id="lbl">E-mail:</label> 
        <input type="text" placeholder="" id="inputemail" name="email_html" v-model="email"><br>
        <button id="button">Confirmar</button>
    </form>
  </div>
</template>

<script type="text/javascript" src="https://cdn.jsdelivr.net/npm/emailjs-com@2.3.2/dist/email.min.js"></script>
<script type="text/javascript">
   (function(){
      emailjs.init("user_QHqiGGrNB2tvG3plzfoRD");
   })();
</script>
<script>
import emailjs from 'emailjs-com'

export default {
    data: function() {
        return {
            message: '',
            email: '',
        }
    }, methods: {
        sendEmail: (e) => {
            console.log(e.target)
           emailjs.sendForm("central.pismire@gmail.com","template_YCTsNPd0",e.target,"user_QHqiGGrNB2tvG3plzfoRD")
           .then((result) => {
               alert("Email enviado com sucesso \n Agradeçemos o seu Feedback !!")
                   this.message  = clearImmediate();
                   this.email    = clearImmediate();
               console.log('SUCESS', result.status, result.text)
           }, (error) => {
               alert("Email não enviado, tente novamente!")
               console.log("FAILED....", error)
           });
        }
    }
}
</script>
 
<style>
#pagajuda {
    margin-top: 50px;
    color: white;
    margin-top: 80px;
}
#h3t {
    text-align: justify;
    margin-left: 300px;
}
#inputajuda{
    margin-right: 0px;
    margin-left: 20px;
    width: 600px;
    height: 40px;
    border-radius: 20px;
}

#lbl {
    margin-right: 518px;    
}

#inputemail {
    margin-left: -510px;
    margin-right: 250px;
    height: 20px;
    width: 250px;
    border-radius: 20px;
}

#button {
    margin-top: 50px;
    width: 150px;
    height: 50px;
    background: #C5BDFB;
    border: solid 1px black;
    border-radius: 10px;    
}


@media(max-width: 420px) {
    #h3t {
        display: inline;
        margin-left: 6px;
        text-align: justify;
        font-size: 18px;
    }
    #inputajuda{
    margin-right: 0px;
    margin-left: 10px;
    width: 300px;
    height: 40px;
    }
    #lbl {
    margin-right: 0px;
    margin-left: 0px;
    font-size: 16px;
    }
    #inputemail {
    margin-left: 0px;
    margin-right: 0px;
    height: 20px;
    width: 200px;
    }
    h1 {
        margin-left: 20px;
    }

}
</style>