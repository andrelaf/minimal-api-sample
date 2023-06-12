using StudentEnrollement.Data;

namespace StudentEnrollment.Data.Contracts
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<Course> GetStudentListAsync(int courseId);
    }

}
