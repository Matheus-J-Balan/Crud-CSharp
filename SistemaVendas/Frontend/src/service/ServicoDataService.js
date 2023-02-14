import http from "../http-common.js"

class ServicoDataService{
    listar(){
        return http.get('/Servico')
    }
    cadastrar(servico){    
        return http.post('Servico', servico)
    }
    atualizar(id, servico){
        return http.put(`/Servico/${id}`, servico)
    }
    obterPorId(id){
        return http.get(`/Servico/${id}`)
    }
    async deletar(id){
        return await http.delete("/Servico /"+id)
    }
}

export default new ServicoDataService()