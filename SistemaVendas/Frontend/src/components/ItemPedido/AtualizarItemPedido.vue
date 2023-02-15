<template>
    <div id="cadastro-servico">
      <h3>Atualizar Item Pedido</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id</label>
              <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
          </div>
          <div>
              <label for="" class="form-label">Id Pedido</label>
              <input type="text" class="form-control" required placeholder="Id Pedido" v-model="itemPedido.pedidoId" disabled>
          </div>
          <div>
              <label for="" class="form-label">Id Servico</label>
              <input type="text" class="form-control" required placeholder="Id Servico" v-model="itemPedido.servicoId" disabled>
          </div>
          <div>
              <label for="" class="form-label">Quantidade</label>
              <input type="text" class="form-control" required placeholder="Ex: 20" v-model="itemPedido.qnt">
          </div>
          <div>
              <label for="" class="form-label">Valor</label>
              <input type="text" class="form-control" required placeholder="Ex:10,00" v-model="itemPedido.valor">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarItemPedido">Atualizar</button>
      </div>
    </div>
  </template>
  
  <script>
import ItemPedidoDataService from '@/service/ItemPedidoDataService'
export default {
      name: "AtualizarItemPedido",
      data(){
          return{
            itemPedido: {
              },
              updateItemPedido: {
                  pedidoId: "",
                  servicoId: "",
                  qnt: "",
                  valor: ""
              }
          }
      },
      methods: {
          atualizarItemPedidoData(){
              this.updateItemPedido.pedidoId = this.itemPedido.pedidoId
              this.updateItemPedido.servicoId = this.itemPedido.servicoId 
              this.updateItemPedido.quantidade = this.itemPedido.qnt 
              this.updateItemPedido.valor = this.itemPedido.valor 
          },
          obterItemPedido(id){
            ItemPedidoDataService.obterPorId(id)
                  .then((response) => {
                      console.log(response.data)
                      this.itemPedido = response.data;
                  })
          },
          atualizarItemPedido(){
              this.atualizarItemPedidoData()
              ItemPedidoDataService.atualizar(this.$route.params.id, this.updateItemPedido)
                  .then(() => {
                      this.$router.push({name: 'ListarItemPedidoView'})
                  })
          },
          
          
      },
      mounted(){
          this.obterItemPedido(this.$route.params.id)
      }
  }
  </script>
  
  <style>
  </style>