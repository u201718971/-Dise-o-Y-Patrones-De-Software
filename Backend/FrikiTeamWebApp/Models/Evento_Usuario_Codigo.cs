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
    
    public partial class Evento_Usuario_Codigo
    {
        public int IEUC { get; set; }
        public int IDEvento_Usuario { get; set; }
        public int IDCodigoEvento { get; set; }
    
        public virtual CodigoEvento CodigoEvento { get; set; }
        public virtual Evento_Usuario Evento_Usuario { get; set; }
    }
}
