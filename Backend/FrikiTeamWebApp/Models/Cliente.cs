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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Evento_Usuario = new HashSet<Evento_Usuario>();
        }
    
        public int IDCliente { get; set; }
        public string NCliente { get; set; }
        public string ApeCliente { get; set; }
        public int Edad_Cliente { get; set; }
        public int NTelefono { get; set; }
        public string Correo_Cliente { get; set; }
        public string Contraseña_Cliente { get; set; }
        public int IDNumero { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Usuario> Evento_Usuario { get; set; }
        public virtual NumeroCasa NumeroCasa { get; set; }
    }
}
