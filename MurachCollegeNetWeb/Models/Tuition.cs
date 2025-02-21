using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MurachCollegeNetWeb.Models;

[Keyless]
[Table("Tuition")]
public partial class Tuition
{
    [Column(TypeName = "smallmoney")]
    public decimal PartTimeCost { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal FullTimeCost { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal PerUnitCost { get; set; }
}
