using Sistema_de_Inventario.DAL;
using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema_de_Inventario.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(RegistroUsuario usuario)
        {
            bool retorno = false;
            try
            {
                var db = new InventarioDB();

              //  if (db.usuario.Find(usuario) != null)
                //        db.Entry(usuario).State = EntityState.Modified;
             //   else
                    db.usuario.Add(usuario);

                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }

    }
}