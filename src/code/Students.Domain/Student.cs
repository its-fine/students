namespace Students.Domain
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    public class Student
    {
        /// <summary>
		/// Gets or sets the unique identifier for the student.
		/// </summary>
		public int Id { get; set; }

        /// <summary>
		/// Gets or sets the student's first name.
		/// </summary>
		public string FirstName { get; set; }

        /// <summary>
		/// Gets or sets the student's last name.
		/// </summary>
		public string LastName { get; set; }
    }
}