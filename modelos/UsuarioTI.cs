using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace modelos
{
    public class UsuarioTI
    {

        public static Usuario IniciarSesion(String usuario, String clave)
        {
            Usuario user = null;
            try
            {
                using (var datos = new webEntities())
                {
                    user = datos.Usuario.Where(p => p.Username == usuario && p.contraseña == clave).FirstOrDefault();
                    
                }

                return user;
            }
            catch (Exception e)
            {
                return user;
            }
        }
    }
}
