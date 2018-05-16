using System.Threading.Tasks;

namespace Students.Domain
{
    /// <summary>
    /// Interface for types that will provide student service operations.
    /// </summary>
    public interface IStudentService
    {
        /// <summary>
        /// Adds a new student to the repository.
        /// </summary>
        /// <param name="student">
        /// Required instance of the <see cref="Student"/> to save.
        /// </param>
        /// <returns>
        /// The unique identifier ot the student that was saved.
        /// </returns>
        Task<int> AddStudent(Student student);
    }
}