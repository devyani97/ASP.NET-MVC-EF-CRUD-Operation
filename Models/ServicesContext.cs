using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASP.NET_MVC_EF_CRUD_Operation.Models
{
    public class ServicesContext:DbContext
    {
        public DbSet<Employee> emp {  get; set; }
    }
}