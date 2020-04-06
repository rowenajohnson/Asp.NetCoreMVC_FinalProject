using FinalProjectStudentTutorialManagement.Models;
using FinalProjectStudentTutorialManagement.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectStudentTutorialManagement.Repository
{
    public class CourseRepository : ICourse
    {
        private DB_Context db;
        public CourseRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Course> GetCourses => db.Courses;

        public void Add(Course _Course)
        {
            if (_Course.CourseId == 0)
            {
                db.Courses.Add(_Course);
                
            }
            else
            {
                var dbEntity = db.Courses.Find(_Course.CourseId);
                dbEntity.CourseName = _Course.CourseName;
                dbEntity.Credits = _Course.Credits;
                
            }
        }

        public Course GetCourse(int? Id)
        {
            return db.Courses.Include(e => e.Enrollments).ThenInclude(s => s.Students).SingleOrDefault(a => a.CourseId == Id);
        }

        public void Remove(int? Id)
        {
            Course dbEntity = db.Courses.Find(Id); ;
            db.Courses.Remove(dbEntity);
            
        }
    }
}
