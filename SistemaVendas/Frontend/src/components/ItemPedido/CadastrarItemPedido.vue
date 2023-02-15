<template>
    <div id="cadastro-servico">
      <h3>Novo Servico</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id Pedido</label>
              <input type="text" class="form-control" required placeholder="Id Pedido" v-model="cadastro.pedidoId">
          </div>
          <div>
              <label for="" class="form-label">Id Servico</label>
              <input type="text" class="form-control" required placeholder="Id Servico" v-model="cadastro.servicoId">
          </div>
          <div>
              <label for="" class="form-label">Quantidade</label>
              <input type="text" class="form-control" required placeholder="Quantidade" v-model="cadastro.qnt">
          </div>
          <div>
              <label for="" class="form-label">Valor</label>
              <input type="text" class="form-control" required placeholder="Valor" v-model="cadastro.valor">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarItemPedido">Cadastrar</button>
      </div>
    </div>
</template>
  
<script>
import ItemPedidoDataService from '@/service/ItemPedidoDataService'
export default {
      name: "CadastroServico",
      data(){
          return{
              cadastro: {
                  "pedidoId": "",
                  "servicoId": "",
                  "qnt": "",
                  "valor": ""
              }
          }
      },
      methods: {
        cadastrarItemPedido(){
              var data = {
                pedidoId: this.cadastro.pedidoId,
                servicoId: this.cadastro.servicoId,
                quantidade: this.cadastro.qnt,
                valor: this.cadastro.valor,
                }
                ItemPedidoDataService.cadastrar(data)
                  .then(() => {
                      this.$router.push('/itemPedido/listar')
                  })
          }
      }
  }
  </script>
  
  <style>
  </style>