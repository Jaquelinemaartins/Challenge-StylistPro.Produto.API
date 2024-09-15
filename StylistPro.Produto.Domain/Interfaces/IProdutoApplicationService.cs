using StylistPro.Produto.Domain.Entities;

namespace StylistPro.Produto.Domain.Interfaces
{
    public interface IProdutoApplicationService
    {
        IEnumerable<ProdutoEntity> ObterTodosProdutos();
        ProdutoEntity? ObterProdutoPorId(int id);
        ProdutoEntity? SalvarDadosProduto(ProdutoEntity entity);
        ProdutoEntity? EditarDadosProduto(ProdutoEntity entity);
        ProdutoEntity? DeletarDadosProduto(int id);
    }
}