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

  public partial class location
  {
    public location()
    {
      locked = 0;
    }

    [Key]
    public int id { get; set; }

    [Required]
    public string location_string { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string postcode { get; set; }
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string country { get; set; }
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string state { get; set; }
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string street { get; set; }
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string number { get; set; }
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string suburub { get; set; }

    public int locked { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string comment { get; set; }
  }
}
