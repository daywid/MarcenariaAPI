using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcenariaApi.Models;

namespace MarcenariaApi.Data
{
    public class MarcenariaDbContext: DbContext
    {
        
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Agenda> Agendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=estacionamento.db;Cache=Shared");
    }

}

}