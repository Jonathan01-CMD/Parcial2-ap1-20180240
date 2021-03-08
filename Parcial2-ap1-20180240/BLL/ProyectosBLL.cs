using Microsoft.EntityFrameworkCore;
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
    public class ProyectosBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.Proyectos.Any(e => e.ProyectoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Insertar(Proyectos proyectos)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Add(proyectos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Modificar(Proyectos proyectos)
        {
        Contexto contexto = new Contexto();
        bool paso = false;
        try
        {
            contexto.Database.ExecuteSqlRaw($"Delete FROM ProyectoDetalle Where ProyectoId ={proyectos.ProyectoId}");
            foreach (var anterior in proyectos.Detalle)
            {
                contexto.Entry(anterior).State = EntityState.Added;
                paso = contexto.SaveChanges() > 0;
            }
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            contexto.Dispose();
        }

        return paso;
     
        }
        public static bool Guardar(Proyectos proyectos)
        {
            if (!Existe(proyectos.ProyectoId))
                return Insertar(proyectos);
            else
                return Modificar(proyectos);
        }
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var proyecto = contexto.Proyectos.Find(id);
                if(proyecto != null)
                {
                    contexto.Entry(proyecto).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static Proyectos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Proyectos proyectos;
            try
            {
                proyectos = contexto.Proyectos.Include(e => e.Detalle).Where(c => c.ProyectoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return proyectos;
        }
        public static List<Proyectos> GetProyectos()
        {
            Contexto contexto = new Contexto();
            List<Proyectos> lista = new List<Proyectos>();
            try
            {
                lista = contexto.Proyectos.ToList(); 
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
        public static List<Proyectos>GetlList(Expression<Func<Proyectos,bool>> criterios)
        {
            Contexto contexto = new Contexto();
            List<Proyectos> lista = new List<Proyectos>();
            try
            {
                lista = contexto.Proyectos.Where(criterios).ToList();
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

