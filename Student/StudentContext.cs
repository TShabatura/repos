
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Student
{
    class StudentContext : DbContext
    {
        public StudentContext ()
            : base("DbConnection")
        { }
        public DbSet<Student> Students { get; set; }
    }
}
