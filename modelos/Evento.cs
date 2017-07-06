//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.Participantes = new HashSet<Participantes>();
        }
    
        public int ID_Evento { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string Lugar { get; set; }
        public Nullable<int> Costo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Hora { get; set; }
        public Nullable<System.DateTime> Fecha_pub { get; set; }
        public Nullable<System.DateTime> Fecha_ini { get; set; }
        public Nullable<System.DateTime> Fecha_fin { get; set; }
        public Nullable<int> ID_Usuario_crea { get; set; }
        public Nullable<int> ID_Usuario_mod { get; set; }
        public Nullable<System.DateTime> Fecha_mod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participantes> Participantes { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}