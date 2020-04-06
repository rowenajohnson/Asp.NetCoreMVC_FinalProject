using FinalProjectStudentTutorialManagement.Models;
using FinalProjectStudentTutorialManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectStudentTutorialManagement.Repository
{
    public class GenderRepository : IGender
    {
        private DB_Context db;
        public GenderRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Gender> GetGenders => db.Gender;

        public void Add(Gender _Gender)
        {
            db.Gender.Add(_Gender);
            
        }

        public Gender GetGender(int? Id)
        {
            return db.Gender.Find(Id);
        }

        public void Remove(int? Id)
        {
            Gender dbEntity = db.Gender.Find(Id);
            db.Gender.Remove(dbEntity);
            
        }
    }
}
