<template>
    <div id="cadastro-pedido">
      <h3>Novo Pedido</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Data</label>
              <input type="text" class="form-control" disabled :value="toLocaleDate(dateToView)">
          </div>
          <div>
              <label for="" class="form-label">Vendedor</label>
              <br>
              <select name="vendedor" id="vendedor" v-model="cadastro.vendedorId" class="form-select">
                  <option v-for="(vendedor, index) in Vendedores" :key="index" :value="vendedor.id">{{ vendedor.nome }}</option>
              </select>
          </div>
          <div>
              <label for="" class="form-label">Cliente</label>
              <br>
              <select name="cliente" id="cliente" v-model="cadastro.clienteId" class="form-select">
                  <option v-for="(cliente, index) in Clientes" :key="index" :value="cliente.id">{{ cliente.nome }}</option>
              </select>
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarVendedor">Cadastrar</button>
      </div>
    </div>
  </template>
  
  <script>
import PedidoDataService from '@/service/PedidoDataService'
import ClienteDataService from '@/service/ClienteDataService'
import VendedorDataService from '@/service/VendedorDataService'
  export default {
      name: "FormCadastroPedido",
      data(){
          return{
              dateToView: new Date(),
              cadastro: {
                  data: new Date().toISOString(),
                  clienteId: "",
                  vendedorId: ""
              },
              Vendedores: [],
              Clientes: []
          }
      },
      methods: {
          cadastrarVendedor(){
              PedidoDataService.cadastrar(this.cadastro)
                  .then(() => {
                      this.$router.push('/pedido/listar')
                  })
          },
          toLocaleDate(date){
              let localeDate = date
              return localeDate.toLocaleString()
          }
          
      },
      mounted(){
          VendedorDataService.listar()
          .then((response) => {
              this.Vendedores = response.data
          })
          ClienteDataService.listar()
          .then((response) => {
              this.Clientes = response.data
          })
      }
  }
  </script>
  
  <style>
  </style>