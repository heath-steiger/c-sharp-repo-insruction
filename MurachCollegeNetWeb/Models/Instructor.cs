using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MurachCollegeNetWeb.Models;

public partial class Instructor
{
    [Key]
    [Column("InstructorID")]
    public int InstructorId { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    public bool DepartmentChairman { get; set; }

    public DateOnly? HireDate { get; set; }

    [Column(TypeName = "money")]
    public decimal AnnualSalary { get; set; }

    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [InverseProperty("Instructor")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Instructors")]
    public virtual Department Department { get; set; } = null!;
}
