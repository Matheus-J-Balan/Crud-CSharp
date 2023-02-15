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
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarServico">Cadastrar</button>
      </div>
    </div>
</template>
  
<script>
import ServicoDataService from '@/service/ServicoDataService'

export default {
      name: "CadastroServico",
      data(){
          return{
              cadastro: {
                  "Nome": "",
                  "Descricao": ""
              }
          }
      },
      methods: {
          cadastrarServico(){
              var data = {
                  Nome: this.cadastro.Nome,
                  Descricao: this.cadastro.Descricao,
                }
              ServicoDataService.cadastrar(data)
                  .then(() => {
                      this.$router.push('/servico/listar')
                  })
          }
      }
  }
  </script>
  
  <style>
  </style>