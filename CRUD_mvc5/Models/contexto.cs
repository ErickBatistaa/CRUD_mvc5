using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_mvc5.Models
{
    public class contextos: DbContext
    {
        public DbSet<equipamentos> equipamentoS { get; set; }
    }
}