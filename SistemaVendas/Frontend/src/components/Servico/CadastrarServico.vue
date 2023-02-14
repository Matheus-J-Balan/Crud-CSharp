<template>
    <div id="cadastro-servico">
      <h3>Novo Servico</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Nome</label>
              <input type="text" class="form-control" required placeholder="Nome" v-model="cadastro.Nome">
          </div>
          <div>
              <label for="" class="form-label">Login</label>
              <input type="text" class="form-control" required placeholder="Descricao" v-model="cadastro.Descricao">
          </div>
          <div>
              <label for="" class="form-label">Senha</label>
              <input type="password" class="form-control" required v-model="cadastro.Senha">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarServico">Cadastrar</button>
      </div>
    </div>
</template>
  
<script>
import ClienteDataService from '@/service/ClienteDataService'  
  export default {
      name: "CadastroServico",
      data(){
          return{
              cadastro: {
                  "Nome": "",
                  "Login": "",
                  "Senha": ""
              }
          }
      },
      methods: {
          cadastrarCliente(){
              var data = {
                  Nome: this.cadastro.Nome,
                  Login: this.cadastro.Login,
                  Senha: this.cadastro.Senha,
              }
              ClienteDataService.cadastrar(data)
                  .then(() => {
                      this.$router.push('/cliente/listar')
                  })
          }
      }
  }
  </script>
  
  <style>
  </style>