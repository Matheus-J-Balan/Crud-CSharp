import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import ListarVendedorView from '../views/vendedorView/ListarVendedorView'
import CadastrarVendedorView from '../views/vendedorView/CadastrarVendedorView'
import AtualizarVendedorView from '../views/vendedorView/AtualizarVendedorView'

import ListarClienteView from '../views/clienteView/ListarClienteView'
import CadastrarClienteView from '../views/clienteView/CadastrarClienteView'
import AtualizarClienteView from '../views/clienteView/AtualizarClienteView'

import ListarServicoView from '../views/servicoView/ListarServicoView'
import CadastrarServicoView from '../views/servicoView/CadastrarServicoView'
import AtualizarServicoView from '../views/servicoView/AtualizarServicoView'

import ListarPedidoView from '../views/pedidoView/ListarPedidoView'
import CadastrarPedidoView from '../views/pedidoView/CadastrarPedidoView'
import AtualizarPedidoView from '../views/pedidoView/AtualizarPedidoView'

import ListarItemPedidoView from '../views/itemPedidoView/ListarItemPedidoView'
import CadastrarItemPedidoView from '../views/itemPedidoView/CadastrarItemPedidoView'
import AtualizarItemPedidoView from '../views/itemPedidoView/AtualizarItemPedidoView'

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
    name: 'ListarClienteView',
    component: ListarClienteView
  },
  {
    path: "/cliente/cadastrar",
    name: 'CadastrarClienteView',
    component: CadastrarClienteView
  },
  {
    path: "/cliente/atualizar/:id",
    name: 'AtualizarClienteView',
    component: AtualizarClienteView
  },


  {
    path: "/servico/listar",
    name: 'ListarServicoView',
    component: ListarServicoView
  },
  {
    path: "/servico/cadastrar",
    name: 'CadastrarServicoView',
    component: CadastrarServicoView
  },
  {
    path: "/servico/atualizar/:id",
    name: 'AtualizarServicoView',
    component: AtualizarServicoView
  },


  {
    path: "/pedido/listar",
    name: 'ListarPedidoView',
    component: ListarPedidoView
  },
  {
    path: "/pedido/cadastrar",
    name: 'CadastrarPedidoView',
    component: CadastrarPedidoView
  },
  {
    path: "/pedido/atualizar/:id",
    name: 'AtualizarPedidoView',
    component: AtualizarPedidoView
  },

  
  {
    path: "/itemPedido/listar",
    name: 'ListarItemPedidoView',
    component: ListarItemPedidoView
  },
  {
    path: "/itemPedido/cadastrar",
    name: 'CadastrarItemPedidoView',
    component: CadastrarItemPedidoView
  },
  {
    path: "/itemPedido/Atualizar/:id",
    name: 'AtualizarItemPedidoView',
    component: AtualizarItemPedidoView
  }
 
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
