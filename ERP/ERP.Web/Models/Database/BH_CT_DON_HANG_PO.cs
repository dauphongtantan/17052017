
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
    
public partial class BH_CT_DON_HANG_PO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BH_CT_DON_HANG_PO()
    {

        this.MH_PO_CT_MUA_HANG = new HashSet<MH_PO_CT_MUA_HANG>();

    }


    public int ID { get; set; }

    public string MA_SO_PO { get; set; }

    public string MA_HANG { get; set; }

    public string MA_DIEU_CHINH { get; set; }

    public string DVT { get; set; }

    public int SO_LUONG { get; set; }

    public decimal DON_GIA { get; set; }

    public decimal THANH_TIEN_HANG { get; set; }

    public double THUE_GTGT { get; set; }

    public double TIEN_THUE_GTGT { get; set; }

    public double TIEN_THANH_TOAN { get; set; }

    public bool DA_BAN { get; set; }

    public bool CAN_GIU_HANG { get; set; }

    public bool DA_XUAT { get; set; }

    public bool CAN_DAT_HANG { get; set; }

    public bool DA_DAT_HANG { get; set; }



    public virtual HH HH { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MH_PO_CT_MUA_HANG> MH_PO_CT_MUA_HANG { get; set; }

}

}