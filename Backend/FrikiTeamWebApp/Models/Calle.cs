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
    
    public partial class Calle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calle()
        {
            this.NumeroCasa = new HashSet<NumeroCasa>();
        }
    
        public int IDCalle { get; set; }
        public string NCalle { get; set; }
        public int IDDistrito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NumeroCasa> NumeroCasa { get; set; }
        public virtual Distrito Distrito { get; set; }
    }
}
