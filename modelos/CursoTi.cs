using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelos
{
    public class CursoTi
    {

        //    //Lista de los cursos 
        //    static public List<CursoProfesor> ListaCursos(int profesor_id)
        //    {
        //        try
        //        {
        //            List<CursoProfesor> listacurso = new List<CursoProfesor>();

        //            using (var datos = new WebEntities())
        //            {
        //                listacurso = datos.CursoProfesor.Where(p => p.ID_Profesor == profesor_id).ToList();
        //            }
        //            return listacurso;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            return null;
        //        }

        //    }


        //    //Lista de los cursos del profesor
        //    static public List<CursoProfesor> ListaCursoProfesor(int profesor_id)
        //    {
        //        try
        //        {
        //            List<CursoProfesor> listacurso = new List<CursoProfesor>();

        //            using (var datos = new WebEntities())
        //            {
        //                listacurso = datos.CursoProfesor.ToList();
        //            }
        //            return listacurso;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            return null;
        //        }

        //    }

        //    //añadir  un nuevo curso del profesor
        //    static public bool AddCursoProfesor(CursoProfesor cursoAdd)
        //    {
        //        try
        //        {
        //            using (var datos = new WebEntities())
        //            {
        //                datos.CursoProfesor.Add(cursoAdd);
        //                datos.SaveChanges();
        //            }

        //            return true;
        //        }
        //        catch (Exception e)
        //        {

        //            return false;
        //        }
        //    }

        //    // Método para eliminar un curso del profesor
        //    static public bool EliminarCursoProfesor(int id_cursoProfe)
        //    {
        //        try
        //        {
        //            using (var datos = new WebEntities())
        //            {
        //                CursoProfesor curso = datos.CursoProfesor.Where(ss => ss.ID_CursoProfesor == id_cursoProfe).FirstOrDefault();
        //                datos.CursoProfesor.Remove(curso);
        //                datos.SaveChanges();
        //            }
        //                return true;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            return false;
        //        }
        //    }
        //}
    }
}
