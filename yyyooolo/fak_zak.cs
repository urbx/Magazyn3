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
    
    public partial class fak_zak
    {
        public int nr_faktury { get; set; }
        public System.DateTime data_wystawienia { get; set; }
        public System.DateTime data_zakupu { get; set; }
        public int id_dostawcy { get; set; }
        public string nazwa_towaru { get; set; }
        public int ilosc { get; set; }
        public string sposob_zaplaty { get; set; }
        public System.DateTime termin_zaplaty { get; set; }
        public int id_prac { get; set; }
        public double cena_zakupu { get; set; }
        public string symbol { get; set; }
        public Nullable<int> id_towaru { get; set; }
    
        public virtual Dostawcy Dostawcy { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual towary towary { get; set; }
    }
}