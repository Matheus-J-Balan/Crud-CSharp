<template>
    <div id="cadastro-servico">
      <h3>Atualizar Servico</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id</label>
              <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
          </div>
          <div>
              <label for="" class="form-label">Nome</label>
              <input type="text" class="form-control" required placeholder="Nome" v-model="servico.nome">
          </div>
          <div>
              <label for="" class="form-label">Descrição</label>
              <input type="text" class="form-control" required placeholder="Login" v-model="servico.descricao">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarServico">Atualizar</button>
      </div>
    </div>
  </template>
  
  <script>
import ServicoDataService from '@/service/ServicoDataService'
export default {
      name: "AtualizarServico",
      data(){
          return{
            servico: {
              },
              updateServico: {
                  nome: "",
                  descricao: ""
              }
          }
      },
      methods: {
          atualizarServicoData(){
              this.updateServico.nome = this.servico.nome
              this.updateServico.descricao = this.servico.descricao 
          },
          obterServico(id){
            ServicoDataService.obterPorId(id)
                  .then((response) => {
                      console.log(response.data)
                      this.servico = response.data;
                  })
          },
          atualizarServico(){
              this.atualizarServicoData()
              ServicoDataService.atualizar(this.$route.params.id, this.updateServico)
                  .then(() => {
                      this.$router.push({name: 'ListarServicoView'})
                  })
          },
          
          
      },
      mounted(){
          this.obterServico(this.$route.params.id)
      }
  }
  </script>
  
  <style>
  </style>