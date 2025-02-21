using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MurachCollegeNetWeb.Models;

public partial class Student
{
    [Key]
    [Column("StudentID")]
    public int StudentId { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Precision(0)]
    public DateTime EnrollmentDate { get; set; }

    public DateOnly? GraduationDate { get; set; }
}
