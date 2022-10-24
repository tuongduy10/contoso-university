using ContosoUniversity.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Repositories.Course
{
    public class CourseRepository : RepositoryBase<Data.Models.Course>, ICourseRepository
    {
        public CourseRepository(ContosoUniversityContext DbContext) : base(DbContext) { }
    }
}
