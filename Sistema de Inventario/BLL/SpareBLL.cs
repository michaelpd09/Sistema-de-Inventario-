using Sistema_de_Inventario.DAL;
using Sistema_de_Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Inventario.BLL
{
    public class SpareBLL
    {
        public static bool Guardar(RegistroSpare spare)
        {
            bool retorno = false;
            try
            {
                var db = new InventarioDB();

                //  if (db.usuario.Find(usuario) != null)
                //        db.Entry(usuario).State = EntityState.Modified;
                //   else
                db.spare.Add(spare);

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