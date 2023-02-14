import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import ListarVendedorView from '../views/vendedorView/ListarVendedorView'
import CadastrarVendedorView from '../views/vendedorView/CadastrarVendedorView'
import AtualizarVendedorView from '../views/vendedorView/AtualizarVendedorView'

import ListarCliente from '../views/cliente/ListarCliente'
import CadastrarCliente from '../views/cliente/CadastrarCliente'

import ListarServico from '../views/servico/ListarServico'
import CadastrarServico from '../views/servico/CadastrarServico'

import ListarPedido from '../views/pedido/ListarPedido'
import CadastrarPedido from '../views/pedido/CadastrarPedido'

import ListarItemPedido from '../views/itemPedido/ListarItemPedido'
import CadastrarItemPedido from '../views/itemPedido/CadastrarItemPedido'

const routes = [
  {
    path: '/',
    name:'home',
    component: HomeView
  },


  {
    path: "/vendedor/listar",
    name: 'ListarVendedorView',
    component: ListarVendedorView
  },
  {
    path: "/vendedor/cadastrar",
    name: 'CadastrarVendedorView',
    component: CadastrarVendedorView
  },
  {
    path: "/vendedor/atualizar/:id",
    name: 'AtualizarVendedorView',
    component: AtualizarVendedorView
  },


  {
    path: "/cliente/listar",
    name: 'ListarCliente',
    component: ListarCliente
  },
  {
    path: "/cliente/cadastrar",
    name: 'CadastrarCliente',
    component: CadastrarCliente
  },


  {
    path: "/servico/listar",
    name: 'ListarServico',
    component: ListarServico
  },
  {
    path: "/servico/cadastrar",
    name: 'CadastrarServico',
    component: CadastrarServico
  },


  {
    path: "/pedido/listar",
    name: 'ListarPedido',
    component: ListarPedido
  },
  {
    path: "/pedido/cadastrar",
    name: 'CadastrarPedido',
    component: CadastrarPedido
  },

  
  {
    path: "/itemPedido/listar",
    name: 'ListarItemPedido',
    component: ListarItemPedido
  },
  {
    path: "/itemPedido/cadastrar",
    name: 'CadastrarItemPedido',
    component: CadastrarItemPedido
  }
 
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
