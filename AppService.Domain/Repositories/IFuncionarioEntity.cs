using AppService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Domain.Repositories
{
    public interface IFuncionarioEntity : IBaseRepository<FuncionarioEntity>
    {
        // aqui é moleza, só precisamos implementar a interface base do repositório e passar a entidade.
        // Para implementar a interface é só fazer igual a herança

    }
}
