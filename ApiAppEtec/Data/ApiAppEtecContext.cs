using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiAppEtec.Models;

namespace ApiAppEtec.Data
{
    public class ApiAppEtecContext : DbContext
    {
        public ApiAppEtecContext (DbContextOptions<ApiAppEtecContext> options)
            : base(options)
        {
        }

        public DbSet<ApiAppEtec.Models.Aluno> Aluno { get; set; } = default!;
    }
}
