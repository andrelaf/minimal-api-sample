using StudentEnrollement.Data;
using StudentEnrollment.Data.Contracts;

namespace StudentEnrollment.Data.Respositories
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(StudentEnrollmentDbContext db) : base(db) { }

      
    }
}
