using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.VendaGeneric.Domain
{
    public interface IVendaRepository
    {
        void Add(VendaModel venda);

        void Update(VendaModel venda);

        void Remove(VendaModel venda);


        VendaModel GetById(long vendaId);

        ICollection<VendaModel> GetByNome(string nome);

        ICollection<VendaModel> GetAll();
    }
}
