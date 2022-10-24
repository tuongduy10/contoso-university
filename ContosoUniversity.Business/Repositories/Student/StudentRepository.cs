using ContosoUniversity.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Repositories.Student
{
    public class StudentRepository : RepositoryBase<Data.Models.Student>, IStudentRepository
    {
        public StudentRepository(ContosoUniversityContext DbContext) : base(DbContext) { }
    }
}
