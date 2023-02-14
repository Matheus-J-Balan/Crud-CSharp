<template>
    <div id="cadastro-vendedor">
      <h3>Atualizar Vendedor</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id</label>
              <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
          </div>
          <div>
              <label for="" class="form-label">Nome</label>
              <input type="text" class="form-control" required placeholder="Nome" v-model="vendedor.nome">
          </div>
          <div>
              <label for="" class="form-label">Login</label>
              <input type="text" class="form-control" required placeholder="Login" v-model="vendedor.login" disabled>
          </div>
          <div>
              <label for="" class="form-label">Senha</label>
              <input type="password" class="form-control" required v-model="vendedor.senha">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarVendedor">Atualizar</button>
      </div>
    </div>
  </template>
  
  <script>
import VendedorDataService from '@/service/VendedorDataService'
export default {
      name: "AtualizarVendedor",
      data(){
          return{
              vendedor: {
              },
              updateVendedor: {
                  nome: "",
                  login: "",
                  senha: ""
              }
          }
      },
      methods: {
          atualizarVendedorData(){
              this.updateVendedor.senha = this.vendedor.senha
              this.updateVendedor.login = this.vendedor.login 
              this.updateVendedor.nome = this.vendedor.nome
          },
          obterVendedor(id){
              VendedorDataService.obterPorId(id)
                  .then((response) => {
                      console.log(response.data)
                      this.vendedor = response.data;
                  })
          },
          atualizarVendedor(){
              this.atualizarVendedorData()
              VendedorDataService.atualizar(this.$route.params.id, this.updateVendedor)
                  .then(() => {
                      this.$router.push({name: 'ListarVendedorView'})
                  })
          },
          
          
      },
      mounted(){
          this.obterVendedor(this.$route.params.id)
      }
  }
  </script>
  
  <style>
  </style>