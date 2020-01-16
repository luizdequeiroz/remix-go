import swal from 'sweetalert2';

export const treatUsuario = (payload) => ({
    nome: payload.nomeFantasia,
    filial: payload.filial,
    uf: payload.uf,
    matricula: payload.codigo
})

export const treatProduto = response => {
    if (response.result) {
        if (response.content.error) {
            swal.fire({
                title: 'Falha na busca de produto.',
                text: response.content.mensagem,
                type: 'info'
            });
        } else {
            return response.content;
        }
    } else {
        swal.fire({
            title: response.message || 'Erro na requisição.',
            type: 'error'
        });
    }
}

export const treatAutorizacoes = response => response.content || [];