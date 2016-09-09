using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TodoWeb.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext() : base("StrConn")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}