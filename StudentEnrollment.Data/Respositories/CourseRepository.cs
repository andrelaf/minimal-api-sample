using Microsoft.EntityFrameworkCore;
using StudentEnrollement.Data;
using StudentEnrollment.Data.Contracts;

namespace StudentEnrollment.Data.Respositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(StudentEnrollmentDbContext db) : base(db) { }

        public async Task<Course> GetStudentListAsync(int courseId)
        {
            var course = await _db.Courses
                .Include(q => q.Enrollments).ThenInclude(q => q.Student)
                .FirstOrDefaultAsync(q => q.Id == courseId);

            return course;
        }
    }
}

