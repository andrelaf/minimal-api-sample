using StudentEnrollement.Data;

namespace StudentEnrollment.Data.Contracts
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> GetStudentDetailsAsync(int studentId);
    }

}
