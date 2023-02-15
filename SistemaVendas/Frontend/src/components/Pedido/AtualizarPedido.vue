<template>
    <div id="atualizar-pedido">
      <h3>Atualiazar Pedido</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id</label>
              <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
          </div>
          <div>
              <label for="" class="form-label">Vendedor Atual</label>
              <input type="text" class="form-control" required placeholder="Id" :value="pedido.vendedorId" disabled>
          </div>
          <div>
              <label for="" class="form-label">Vendedor Novo</label>
              <br>
              <select name="vendedor" id="vendedor" v-model="updatePedido.VendedorId" class="form-select">
                  <option v-for="(vendedor, index) in vendedores" :key="index" :value="vendedor.id">{{ vendedor.nome }}</option>
              </select>
          </div>
          <div>
              <label for="" class="form-label">Cliente Atual</label>
              <input type="text" class="form-control" required placeholder="Id" :value="pedido.clienteId" disabled>
          </div>
          <div>
              <label for="" class="form-label">Cliente Novo</label>
              <br>
              <select name="vendedor" id="vendedor" v-model="updatePedido.ClienteId" class="form-select">
                  <option v-for="(cliente, index) in clientes" :key="index" :value="cliente.id">{{ cliente.nome }}</option>
              </select>
          </div>
  
          <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarPedido">Atualizar</button>
      </div>
    </div>
  </template>
  
  <script>
import PedidoDataService from '@/service/PedidoDataService';
import ClienteDataService from '@/service/ClienteDataService';
import VendedorDataService from '@/service/VendedorDataService';
  export default {
      name: "AtualizarPedido",
      data(){
          return{
              pedido: {
              },
              vendedores:{
              },
              clientes:{
              },
              updatePedido: {
                  VendedorId: "",
                  ClienteId: "",
                  data: new Date().toISOString(),
              },
          }
      },
      methods: {
          obterPedido(id){
              PedidoDataService.obterPorId(id)
                  .then((response) => {
                      this.pedido = response.data;
                  })
          },
          obterVendedores(){
              VendedorDataService.listar()
                  .then((response) => {
                      this.vendedores = response.data
                      this.vendedores = this.vendedores.filter(item => item.id !== this.pedido.vendedor.id)
                  })
          },
          obterClientes(){
              ClienteDataService.listar()
                  .then((response) => {
                      this.clientes = response.data
                      this.clientes = this.clientes.filter(item => item.id !== this.pedido.cliente.id)
                  })
          },
          atualizarPedido(){
              if(this.updatePedido.ClienteId === ""){
                  this.updatePedido.ClienteId = this.pedido.cliente.id
              }
              if(this.updatePedido.VendedorId === ""){
                  this.updatePedido.VendedorId = this.pedido.vendedor.id
              }
              PedidoDataService.atualizar(this.$route.params.id, this.updatePedido)
                  .then(() => this.$router.push('/pedido/listar'))
          },
      },
      beforeMount(){
          this.obterPedido(this.$route.params.id)
          this.obterVendedores()
          this.obterClientes()
      }
  }
  </script>
  
  <style>
  </style>
