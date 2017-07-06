using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.TI_Web.modelos;

namespace modelos
{
    public class ProfesorTi
    {
        //Lista a todos los profesores
        static public List<PROFESOR> ListaProfesor()
        {
            try
            {
                List<PROFESOR> listaProfe = new List<PROFESOR>();
                using (var datos = new bd_webEntities())
                {
                    listaProfe = datos.PROFESORs.ToList();
                }

                return listaProfe;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Seleccionar o buscar a un profesor por su ID
        static public PROFESOR SelectProfesor(int id_profe)
        {
            try
            {
                PROFESOR profesorSelect = new PROFESOR();
                using (var datos = new bd_webEntities())
                {
                    profesorSelect = datos.PROFESORs.Where(ss => ss.ID_PROFESOR == id_profe).FirstOrDefault();
                }
                    return profesorSelect;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        //Agregar profesor 
        static public bool AgregarProfesor(PROFESOR ProfesorAdd)
        {
            try
            {
                using (var datos = new bd_webEntities())
                {
                    datos.PROFESORs.Add(ProfesorAdd);
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

        //Editar Datos del profesor
        static public bool EditarDatosProfesor(int id_profesor, PROFESOR profeEditar)
        {
            try
            {
                using (var datos = new bd_webEntities())
                {
                    PROFESOR profesor = datos.PROFESORs.Where(ss => ss.ID_PROFESOR == id_profesor).FirstOrDefault();
                    profesor.CORREO = profeEditar.CORREO;
                    profesor.CELULAR = profeEditar.CELULAR;
                    profesor.APELLIDOS = profeEditar.APELLIDOS;
                    profesor.NOMBRES = profeEditar.NOMBRES;
                    profesor.PROFESION = profeEditar.PROFESION;
                    profesor.FECHA_MOD = profeEditar.FECHA_MOD;
                    profesor.DIRECCION = profeEditar.DIRECCION;


                    datos.SaveChanges();
                
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //Eliminar al profesor por su id
        static public bool EliminarProfesor(int id_profesor)
        {
            try
            {
                using (var datos = new bd_webEntities())
                {
                    PROFESOR profe = datos.PROFESORs.Where(ss => ss.ID_PROFESOR == id_profesor).FirstOrDefault();
                    datos.PROFESORs.Remove(profe);
                    datos.SaveChanges();
                
                }
                    return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}
