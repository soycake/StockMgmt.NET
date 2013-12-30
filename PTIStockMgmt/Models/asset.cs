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

  public partial class asset
  {

    public asset()
    {
      locked = 0;
      links = "";
    }

    [Key]
    public int id { get; set; }
    [Required]
    public string title { get; set; }
    [Required]
    public int price { get; set; }
    [Required]
    public int weight { get; set; }
    [Required]
    public int volume { get; set; }
    [Required]
    public int sap { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string comment { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string maker { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string links { get; set; }

    public int locked { get; set; }
  }
}
