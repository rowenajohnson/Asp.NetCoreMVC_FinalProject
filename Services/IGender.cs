using FinalProjectStudentTutorialManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectStudentTutorialManagement.Services
{
    interface IGender
    {
        IEnumerable<Gender> GetGenders { get; }
        Gender GetGender(int? Id);
        void Add(Gender _Gender);
        void Remove(int? Id);
    }
}
