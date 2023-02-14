<template>
    <div id="cadastro-vendedor">
      <h3>Novo Vendedor</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Nome</label>
              <input type="text" class="form-control" required placeholder="Nome" v-model="cadastro.Nome">
          </div>
          <div>
              <label for="" class="form-label">Login</label>
              <input type="text" class="form-control" required placeholder="Login" v-model="cadastro.Login">
          </div>
          <div>
              <label for="" class="form-label">Senha</label>
              <input type="password" class="form-control" required v-model="cadastro.Senha">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarVendedor">Cadastrar</button>
      </div>
    </div>
</template>
  
<script>
import VendedorDataService from '@/service/VendedorDataService';
  
  export default {
      name: "CadastroVendedor",
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
          cadastrarVendedor(){
              var data = {
                  Nome: this.cadastro.Nome,
                  Login: this.cadastro.Login,
                  Senha: this.cadastro.Senha,
              }
              VendedorDataService.cadastrar(data)
                  .then(() => {
                      this.$router.push('/vendedor/listar')
                  })
          }
      }
  }
  </script>
  
  <style>
  </style>