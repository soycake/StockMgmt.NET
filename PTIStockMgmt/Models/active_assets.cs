//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTIStockMgmt.Models
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;

  public partial class active_assets
  {
    public active_assets()
    {
      locked = 0;
    }

    [Key]
    public int id { get; set; }

    [Required]
    public int asset_id { get; set; }

    [Required]
    public int location_id { get; set; }

    [Required]
    public int quantity { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string comment { get; set; }

    public int locked { get; set; }
  }

}
