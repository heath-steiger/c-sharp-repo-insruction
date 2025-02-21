using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MurachCollegeNetWeb.Models;

[Index("CourseNumber", Name = "UQ__Courses__A98290ED292869EF", IsUnique = true)]
public partial class Course
{
    [Key]
    [Column("CourseID")]
    public int CourseId { get; set; }

    public int? CourseNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CourseDescription { get; set; } = null!;

    public int CourseUnits { get; set; }

    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [Column("InstructorID")]
    public int InstructorId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Courses")]
    public virtual Department Department { get; set; } = null!;

    [ForeignKey("InstructorId")]
    [InverseProperty("Courses")]
    public virtual Instructor Instructor { get; set; } = null!;
}
