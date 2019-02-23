using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Produto.Domain
{
    public interface ISetorRepository
    {
        void Add(SetorModel setor);

        void Update(SetorModel setor);

        void Remove(SetorModel setor);


        SetorModel GetById(long setorId);

        ICollection<SetorModel> GetByNome(string nome);

        ICollection<SetorModel> GetAll();
    }
}
