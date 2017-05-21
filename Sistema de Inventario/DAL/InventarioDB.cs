using Sistema_de_Inventario.Models;
using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema_de_Inventario.DAL
{
    public class InventarioDB : DbContext
    {
        public InventarioDB() : base("ConStr")
        {

        }
        public virtual DbSet<RegistroUsuario> usuario { get; set; }
        public virtual DbSet<RegistroSpare> spare { get; set; }


    }
}