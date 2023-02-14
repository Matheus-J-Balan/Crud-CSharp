<template>
    <div class="col-7 center">
      <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Nome</th>
              <th scope="col">Login</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(vendedor, index) in vendedores" :key="index">
              <th scope="row">{{ vendedor.id }}</th>
              <td>{{ vendedor.nome }}</td>
              <td>{{ vendedor.login }}</td>
              <td>
                <button class="btn btn-success" @click="editarVendedor(vendedor.id)">Editar</button>
                <button class="btn btn-danger" @click="excluirVendedor(vendedor)">Excluir</button>
              </td>
            </tr>
          </tbody>
      </table>
    </div>
  </template>
  
  <script>
import VendedorDataService from '@/service/VendedorDataService'  
export default {
    name: "ListarVendedor",
    data() {
      return{
        vendedores: []
      }
    },
    methods: {
      obterVendedores() {
        VendedorDataService.listar()
          .then(response => this.vendedores = response.data)
      },
      editarVendedor(id){
        this.$router.push("/vendedor/atualizar/"+id)
      },
      async excluirVendedor(vendedor){
        if(confirm(`Tem certeza que deseja excluir o vendedor ${vendedor.nome}`)){
          await VendedorDataService.deletar(vendedor.id)
          this.obterVendedores();
        }
      }
    },
    mounted(){
      this.obterVendedores()
    }
  }
  </script>
  
  <style>
  </style>