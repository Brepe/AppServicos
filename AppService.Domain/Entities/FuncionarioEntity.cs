using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Domain.Entities
{
    public class FuncionarioEntity: BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public FuncionarioEntity()
        {

        }
    }
}
