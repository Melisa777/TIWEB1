using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelos
{
    public class ProfesorTi
    {
        
        //Lista a todos los profesores
        static public List<Profesor> ListaProfesor()
        {
            try
            {
                List<Profesor> listaProfe = new List<Profesor>();
                using (var datos = new webEntities())
                {
                    listaProfe = datos.Profesor.Where(p => p.Estado == 1).ToList();
                }

                return listaProfe;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Seleccionar o buscar a un profesor por su ID
        static public Profesor SelectProfesor(int id_profe)
        {
            try
            {
                Profesor profesorSelect = new Profesor();
                using (var datos = new webEntities())
                {
                    profesorSelect = datos.Profesor.Where(ss => ss.ID_Profesor == id_profe).FirstOrDefault();
                }
                return profesorSelect;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        //Agregar profesor 
        static public bool AgregarProfesor(Profesor ProfesorAdd)
        {
            try
            {
                using (var datos = new webEntities())
                {
                    datos.Profesor.Add(ProfesorAdd);
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
        static public bool EditarDatosProfesor(int id_profesor, Profesor profeEditar)
        {
            try
            {
                using (var datos = new webEntities())
                {
                    Profesor profesor = datos.Profesor.Where(ss => ss.ID_Profesor == id_profesor).FirstOrDefault();
                    profesor.Correo = profeEditar.Correo;
                    profesor.Celular = profeEditar.Celular;
                    profesor.Apellidos = profeEditar.Apellidos;
                    profesor.Nombres = profeEditar.Nombres;
                    profesor.Profesion = profeEditar.Profesion;
                    profesor.Fecha_mod = profeEditar.Fecha_mod;
                    profesor.Direccion = profeEditar.Direccion;


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
                using (var datos = new webEntities())
                {
                    Profesor profe = datos.Profesor.Where(ss => ss.ID_Profesor == id_profesor).FirstOrDefault();
                    datos.Profesor.Remove(profe);
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

