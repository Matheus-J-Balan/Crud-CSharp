import http from "../http-common.js"

class VendedorDataService{
    listar(){
        return http.get('/Cliente')
    }
    cadastrar(cliente){    
        return http.post('Cliente', cliente)
    }
    atualizar(id, cliente){
        return http.put(`/Cliente/${id}`, cliente)
    }
    obterPorId(id){
        return http.get(`/Cliente/${id}`)
    }
    async deletar(id){
        return await http.delete("/Cliente/"+id)
    }
}

export default new VendedorDataService()