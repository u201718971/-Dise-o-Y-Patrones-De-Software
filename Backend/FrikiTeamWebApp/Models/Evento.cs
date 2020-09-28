//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrikiTeamWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.CodigoEvento = new HashSet<CodigoEvento>();
            this.Evento_Usuario = new HashSet<Evento_Usuario>();
        }
    
        public int IDEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public int IDDistrito { get; set; }
        public int PrecioEntrada { get; set; }
        public Nullable<int> NCupos { get; set; }
        public string NEvento { get; set; }
        public int IDOrganizador { get; set; }
        public string FechaEvento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodigoEvento> CodigoEvento { get; set; }
        public virtual Distrito Distrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Usuario> Evento_Usuario { get; set; }
        public virtual Organizador Organizador { get; set; }
    }
}