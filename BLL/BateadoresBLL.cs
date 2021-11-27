using Entrenamiento_Bateo.Models;
using Entrenamiento_Bateo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Entrenamiento_Bateo.BLL
{
    public class BateadoresBLL
    {
        public static bool Guardar(Bateadores bateadores)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Bateadores.Add(bateadores);
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static List<Bateadores> GetList(Expression<Func<Bateadores,bool>> criterio)
        {
            List<Bateadores> lista = new List<Bateadores>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Bateadores.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
