using Parcial2_ap1_20180240.DAL;
using Parcial2_ap1_20180240.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180240.BLL
{
    public class TareasBLL
    {
        public static Tarea Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Tarea tareas;

            try
            {
                tareas = contexto.Tarea.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tareas;
        }
        public static List<Tarea> GetTarea()
        {
            Contexto contexto = new Contexto();
            List<Tarea> lista = new List<Tarea>();
            try
            {
                lista = contexto.Tarea.ToList();
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
        public static List<Tarea>GetlList(Expression<Func<Tarea, bool>> criterios)
        {
            Contexto contexto = new Contexto();
            List<Tarea> lista = new List<Tarea>();
            try
            {
                lista = contexto.Tarea.Where(criterios).ToList();
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
