using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MurachCollegeNetWeb.Models;

[Index("DepartmentName", Name = "UQ__Departme__D949CC34D50B726D", IsUnique = true)]
public partial class Department
{
    [Key]
    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [InverseProperty("Department")]
    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
