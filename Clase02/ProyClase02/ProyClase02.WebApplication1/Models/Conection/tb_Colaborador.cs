//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyClase02.WebApplication1.Models.Conection
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Colaborador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Colaborador()
        {
            this.tb_ContactoCliente = new HashSet<tb_ContactoCliente>();
        }
    
        public int idColaborador { get; set; }
        public string nombreColaborador { get; set; }
        public string apellidoColaborador { get; set; }
        public string numeroDocumentoColaborador { get; set; }
        public int idRol { get; set; }
        public int idTipoDocumento { get; set; }
        public Nullable<int> idubigeo { get; set; }
        public string nombUser { get; set; }
    
        public virtual tb_Ubigeo tb_Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ContactoCliente> tb_ContactoCliente { get; set; }
        public virtual tb_Rol tb_Rol { get; set; }
        public virtual tb_TipoDocumento tb_TipoDocumento { get; set; }
    }
}