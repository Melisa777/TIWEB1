using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.TI_Web.modelos;

namespace modelos
{
    public class CursoTi
    {

        //Lista de los cursos 
        static public List<CURSO> ListaCursos(int profesor_id)
        {
            try
            {
                List<CURSO> listacurso = new List<CURSO>();

                using (var datos = new bd_webEntities())
                {
                    listacurso = datos.CURSOes.ToList();
                }
                return listacurso;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }


        //Lista de los cursos del profesor
        static public List<CURSO> ListaCursoProfesor(int profesor_id)
        {
            try
            {
                List<CURSO> listacurso = new List<CURSO>();

                using (var datos = new bd_webEntities())
                {
                    listacurso = datos.CURSOes.Where(ss => ss.ID_PROFESOR == profesor_id).ToList();
                }
                return listacurso;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        //añadir  un nuevo curso del profesor
        static public bool AddCursoProfesor(CURSO cursoAdd)
        {
            try
            {
                using (var datos = new bd_webEntities())
                {
                    datos.CURSOes.Add(cursoAdd);
                    datos.SaveChanges();
                }

                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }


        // Editar curso del profesor
        static public bool EditarCurso(int idCurso, string nombreCurso, int creditos, string descripcion, string horarioCurso)
        {
            try
            {
                using (var datos = new bd_webEntities())
                {
                    CURSO cursoEditar = datos.CURSOes.Where(ss => ss.ID_CURSO == idCurso).FirstOrDefault();
                    cursoEditar.NOMBRE = nombreCurso;
                    cursoEditar.CREDITOS = creditos;
                    cursoEditar.DESCRIPCION = descripcion;
                    cursoEditar.HORARIO = horarioCurso;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }




        // Método para eliminar un curso del profesor
        static public bool EliminarCursoProfesor(int id_cursoProfe)
        {
            try
            {
                using (var datos = new bd_webEntities())
                {
                    CURSO curso = datos.CURSOes.Where(ss => ss.ID_CURSO == id_cursoProfe).FirstOrDefault();
                    datos.CURSOes.Remove(curso);
                    datos.SaveChanges();
                }
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
