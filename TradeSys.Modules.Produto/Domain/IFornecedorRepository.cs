using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Produto.Domain
{
    public interface IFornecedorRepository
    {
        void Add(FornecedorModel fornecedor);

        void Update(FornecedorModel fornecedor);

        void Remove(FornecedorModel fornecedor);


        FornecedorModel GetById(long fornecedorId);

        ICollection<FornecedorModel> GetByNome(string nome);

        ICollection<FornecedorModel> GetAll();
    }
}
