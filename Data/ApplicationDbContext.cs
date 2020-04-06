using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalProjectStudentTutorialManagement.Models;

namespace FinalProjectStudentTutorialManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FinalProjectStudentTutorialManagement.Models.Student> Student { get; set; }
        public DbSet<FinalProjectStudentTutorialManagement.Models.Course> Course { get; set; }
        public DbSet<FinalProjectStudentTutorialManagement.Models.Gender> Gender { get; set; }
        public DbSet<FinalProjectStudentTutorialManagement.Models.Enrollment> Enrollment { get; set; }
    }
}
