
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
    
public partial class CN_NGHIEP_VU_NHAN_VIEN
{

    public int ID_CHI_TIET_NGHIEP_VU { get; set; }

    public string USERNAME { get; set; }

    public string MO_TA { get; set; }



    public virtual CN_CHI_TIET_NGHIEP_VU CN_CHI_TIET_NGHIEP_VU { get; set; }

    public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }

}

}