using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PublicerenWeb.Entities;

public partial class Actiecode
{
    public int ActiecodeId { get; set; }

    public string Naam { get; set; } = null!;

    [Display(Name ="Geldig vanaf")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime GeldigVanDatum { get; set; }
    [Display(Name = "Geldig tot")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime GeldigTotDatum { get; set; }
    [Display(Name = "Eenmalig?")]
    public bool IsEenmalig { get; set; }
}
