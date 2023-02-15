<template>
<div class="col-7">
  <table class="table table-striped">
      <thead>
        <tr>
          <th scope="col">#</th>
          <th scope="col">Pedido</th>
          <th scope="col">Servico</th>
          <th scope="col">Quantidade</th>
          <th scope="col">Valor</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(itemPedido, index) in itensPedido" :key="index">
          <th scope="row">{{ itemPedido.id }}</th>
          <td scope="row">{{ itemPedido.pedidoId }}</td>
          <td scope="row">{{ itemPedido.servicoId }}</td>
          <td>{{ itemPedido.quantidade }}</td>
          <td>{{ itemPedido.valor }}</td>
          <td>
            <button class="btn btn-success" @click="editarItemPedido(itemPedido.id)">Editar</button>
            <button class="btn btn-danger" @click="excluirItemPedido(itemPedido)">Excluir</button>
          </td>
        </tr>
      </tbody>
  </table>
</div>
</template>

<script>
import ItemPedidoDataService from '@/service/ItemPedidoDataService'

export default {
name: "ListarItemPedido",
data() {
  return{
    itensPedido: []
  }
},
methods: {
  obterItensPedido() {
    ItemPedidoDataService.listar()
      .then(response => this.itensPedido = response.data)
  },
  editarItemPedido(id){
    this.$router.push("/itemPedido/atualizar/"+id)
  },
  async excluirItemPedido(itemPedido){
    if(confirm(`Tem certeza que deseja excluir o item do pedido ${itemPedido.id}`)){
      await ItemPedidoDataService.deletar(itemPedido.id)
      this.obterItensPedido();
    }
  },
},
computed: {
},
mounted(){
  this.obterItensPedido()
}
}
</script>

<style>
</style>