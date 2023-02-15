<template>
    <div class="col-7">
      <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Data</th>
              <th scope="col">Vendedor</th>
              <th scope="col">Cliente</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(pedido, index) in pedidos" :key="index">
              <th scope="row">{{ pedido.id }}</th>
              <td scope="row">{{ toLocaleDate(pedido.data) }}</td>
              <td>{{ pedido.vendedorId }}</td>
              <td>{{ pedido.clienteId }}</td>
              <td>{{ pedido.clienteId }}</td>
              <td>
                <button class="btn btn-success" @click="editarPedido(pedido.id)">Editar</button>
                <button class="btn btn-danger" @click="excluirPedido(pedido)">Excluir</button>
              </td>
            </tr>
          </tbody>
      </table>
    </div>
  </template>
  
  <script>
import PedidoDataService from '@/service/PedidoDataService'

export default {
    name: "ListarPedido",
    data() {
      return{
        pedidos: [],
      }
    },
    methods: {
      obterPedidos() {
        PedidoDataService.listar()
          .then(response => this.pedidos = response.data)
      },
      editarPedido(id){
        this.$router.push("/pedido/atualizar/"+id)
      },
      async excluirPedido(pedido){
        if(confirm(`Tem certeza que deseja excluir o pedido ${pedido.id}`)){
          await PedidoDataService.deletar(pedido.id)
          this.obterPedidos();
        }
      },
      buscarItensPedido(id){
        this.$router.push('/pedido/'+id+'/itens-pedido/listar')
      },
      toLocaleDate(date){
        let localeDate = new Date(date)
        return localeDate.toLocaleString()
      },
    },
    computed: {
    },
    mounted(){
      this.obterPedidos()
    }
  }
  </script>
  
  <style>
  </style>