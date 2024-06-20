using SchoolAppGFive.DAL.Core;

namespace SchoolAppGFive.DAL.Entities
{
    public class Student : Person
    {
        public DateTime? EnrollmentDate { get; set; }

    }
}
