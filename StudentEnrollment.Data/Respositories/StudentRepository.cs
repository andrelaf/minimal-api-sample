using Microsoft.EntityFrameworkCore;
using StudentEnrollement.Data;
using StudentEnrollment.Data.Contracts;

namespace StudentEnrollment.Data.Respositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentEnrollmentDbContext db) : base(db) { }

        public async Task<Student> GetStudentDetailsAsync(int studentId)
        {
            var student = await _db.Students
                .Include(q => q.Enrollments).ThenInclude(q => q.Course)
                .FirstOrDefaultAsync(q => q.Id == studentId);

            return student;

        }

    }
}
