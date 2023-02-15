import http from "../http-common.js"

class ItemPedidoDataService{
    listar(){
        return http.get('/ItemPedido')
    }
    cadastrar(itemPedido){
        return http.post('/ItemPedido', itemPedido)
    }
    atualizar(id, itemPedido){
        return http.put(`/ItemPedido/${id}`, itemPedido)
    }
    obterPorId(id){
        return http.get(`/ItemPedido/${id}`)
    }
    async deletar(id){
        return await http.delete("/ItemPedido/"+id)
    }
}

export default new ItemPedidoDataService()