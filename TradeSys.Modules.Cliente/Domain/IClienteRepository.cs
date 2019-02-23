using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Cliente.Domain
{
    public interface IClienteRepository
    {
        void Add(ICliente cliente);

        void Update(ICliente cliente);

        void Remove(ICliente cliente);


        ICliente GetById(long clienteId);

        ICollection<ICliente> GetByNome(string nome);

        ICollection<ICliente> GetBySobrenome(string sobrenome);

        ICollection<ICliente> GetAll();
    }
}
