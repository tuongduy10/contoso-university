using ContosoUniversity.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Repositories.Enrollment
{
    public class EnrollmentRepository : RepositoryBase<Data.Models.Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ContosoUniversityContext DbContext) : base(DbContext) { }
    }
}
