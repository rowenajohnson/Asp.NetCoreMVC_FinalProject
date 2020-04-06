using FinalProjectStudentTutorialManagement.Models;
using FinalProjectStudentTutorialManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectStudentTutorialManagement.Repository
{
    public class EnrollmentRepository : IEnrollment
    {
        private DB_Context db;
        public EnrollmentRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Enrollment> GetEnrollments => db.Enrollments.Include(s => s.Students).Include(c => c.Courses);

        public void Add(Enrollment _Enrollment)
        {
            db.Enrollments.Add(_Enrollment);
            
        }

        public Enrollment GetEnrollment(int? Id)
        {
            return db.Enrollments.Find(Id);
        }

        public void Remove(int? Id)
        {
            Enrollment dbEntity = db.Enrollments.Find(Id);
            db.Enrollments.Remove(dbEntity);
        }
    }
}
