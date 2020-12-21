<template>
  <div id="div3">
      <div id="esq">
            <h3>Apesar de estar pouco tempo no mercado, <br>
                o Pismire tem uma utilidade promissora, <br>
                sua principal área é a de ajudar aqueles <br> 
                que necessitam de um emprego, os que  <br>
                nunca entraram no mercado de trabalho e <br>
                as empresas que desejam encontrar bons <br>
                funcionários.</h3><br>
            <img src="../assets/Grade.png" alt="" width="150px" height="150px" id="graf"><br><br>
            <h3>Na visão do Pismire temos como meta <br>
            ajudar à empregar a população e <br>
            diminuir o desemprego.</h3>
      </div>
      <div id="dir">
            <img src="../assets/Relógio.png" alt="" width="150px" height="150px" id="tempo"><br><br>
            <h3 id=txt3>A missão do Pismire é ajudar os necessitados <br>
            de emprego, alcançando o maior número <br>
            de usuários possível, além de auxiliar as <br>
            empresas com novos empregados requisitados.</h3> <br>
            <img src="../assets/olho.png" alt=""  width="150px" height="150px" id="olho"> 
      </div>
  </div>
</template>

<script>
export default {

}
</script>

<style>

#div3{
    background: #292929;
}

#esq {
    float: left;
    margin-top: 160px;
    margin-left: 220px;
    text-align: justify;
    color: white;
}
#graf {
    margin-left: 118px;
}

#dir {
    float: right;
    margin-top: 160px;  
    margin-right: 220px;
    color:white;
}

#txt3 {
    text-align: justify;
}

@media(max-width: 420px) {
    #div3{
        height: 1000px;

    }

    #esq {
        margin-left: 40px;
        text-align: justify;
        font-size: 15px;
    }
    #graf {
        margin-left: 10 0px;
    }
    #dir {
        float: left;
        margin-left: -50px;
        margin-right: 0px;
    }
    #txt3 {
        text-align: justify;
        margin-right: 0px;
        margin-left: 100px;
        font-size: 15px;
    }
    #olho {
        margin-top: -20px;
        margin-left: 120px;
    }
    #tempo {
        margin-left: 90px;
    }
    *{
        padding: 0px;
        margin: 0px;
    }
}
</style>