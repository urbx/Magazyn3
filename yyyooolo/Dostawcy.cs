//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yyyooolo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dostawcy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dostawcy()
        {
            this.fak_zak = new HashSet<fak_zak>();
        }
    
        public int id_dostawcy { get; set; }
        public string NIP { get; set; }
        public string Nazwa { get; set; }
        public string Ulica { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Miejscowosc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fak_zak> fak_zak { get; set; }
    }
}