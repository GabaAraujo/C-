namespace ApiMina3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


public class TodoContext : DbContext
{

    public TodoContext(DbContextOptions<TodoContext> options) // CONTEXTO - BANCO DE DADOS
       : base(options)
    {




    }

    public DbSet<eqt_real_time> Eqt_real_time { get; set; } //TABELA NOME CRIADA NO MINAAPI

    public DbSet<resource> Resource { get; set; }



}
