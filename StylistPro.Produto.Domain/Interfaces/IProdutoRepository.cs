using StylistPro.Produto.Domain.Entities;

namespace StylistPro.Produto.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<ProdutoEntity> ObterTodos();
        ProdutoEntity? ObterPorId(int id);
        ProdutoEntity? SalvarDados(ProdutoEntity entity);
        ProdutoEntity? EditarDados(ProdutoEntity entity);
        ProdutoEntity? DeletarDados(int id);
    }
}