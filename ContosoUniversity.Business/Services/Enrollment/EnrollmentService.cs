using ContosoUniversity.Business.Repositories.Course;
using ContosoUniversity.Business.Repositories.Enrollment;
using ContosoUniversity.Business.Repositories.Student;
using ContosoUniversity.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Services.Enrollment
{
    public class EnrollmentService : IEnrollmentService
    {
        private ContosoUniversityContext _DbContext;
        private IStudentRepository _studentRepo;
        private ICourseRepository _courseRepo;
        private IEnrollmentRepository _enrollmentRepo;
        public EnrollmentService(ContosoUniversityContext DbContext)
        {
            if (_DbContext == null)
                _DbContext = DbContext;
            if (_studentRepo == null)
                _studentRepo = new StudentRepository(DbContext);
            if (_courseRepo == null)
                _courseRepo = new CourseRepository(_DbContext);
            if (_enrollmentRepo == null)
                _enrollmentRepo = new EnrollmentRepository(_DbContext);
        }
        public IStudentRepository StudentRepo { get => _studentRepo; }
        public ICourseRepository CourseRepo { get => _courseRepo; }
        public IEnrollmentRepository EnrollmentRepo { get => _enrollmentRepo; }

        public async Task<List<string>> GetAllAsync()
        {
            var result = new List<string>();

            var students = await _studentRepo.ToListAsync();
            var enrollments = await _enrollmentRepo.ToListAsync();
            var courses = await _courseRepo.ToListAsync();

            foreach (var course in courses)
            {
                result.Add(course.Title);
            }
            return result;
        }
        
    }
}
