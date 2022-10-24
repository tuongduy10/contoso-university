using ContosoUniversity.Business.Repositories.Course;
using ContosoUniversity.Business.Repositories.Enrollment;
using ContosoUniversity.Business.Repositories.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Services.Enrollment
{
    public interface IEnrollmentService
    {
        IStudentRepository StudentRepo { get; }
        ICourseRepository CourseRepo { get; }
        IEnrollmentRepository EnrollmentRepo { get; }
        Task<List<string>> GetAllAsync();
    }
}
