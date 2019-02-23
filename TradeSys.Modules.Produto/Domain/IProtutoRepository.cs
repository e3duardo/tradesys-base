using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Produto.Domain
{
    public interface IProdutoRepository
    {
        void Add(ProdutoModel produto);

        void Update(ProdutoModel produto);

        void Remove(ProdutoModel produto);


        ProdutoModel GetById(long produtoId);

        ICollection<ProdutoModel> GetByNome(string nome);

        ICollection<ProdutoModel> GetAll();
    }
}
