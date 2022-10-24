using ContosoUniversity.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Repositories.Course
{
    public interface ICourseRepository : IRepositoryBase<Data.Models.Course>
    {
    }
}
