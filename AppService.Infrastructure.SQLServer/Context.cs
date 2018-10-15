using AppService.Infrastructure.SQLServer.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Infrastructure.SQLServer
{
    class Context : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());

                                                           // "add-migration Initial"

    }
    }
}
