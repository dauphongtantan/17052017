
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ERP.Web.Models.Database
{

using System;
    using System.Collections.Generic;
    
public partial class KH_LOAI
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public KH_LOAI()
    {

        this.KH_LOAI1 = new HashSet<KH_LOAI>();

        this.KH_PHAN_LOAI_KHACH = new HashSet<KH_PHAN_LOAI_KHACH>();

    }


    public string MA_LOAI_KHACH { get; set; }

    public string TEN_LOAI_KHACH { get; set; }

    public string DIEN_GIAI { get; set; }

    public string MA_LOAI_KHACH_CHA { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<KH_LOAI> KH_LOAI1 { get; set; }

    public virtual KH_LOAI KH_LOAI2 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<KH_PHAN_LOAI_KHACH> KH_PHAN_LOAI_KHACH { get; set; }

}

}