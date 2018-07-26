using LTM.School.Application.enumType;

namespace LTM.School.Core.Models
{
    /// <summary>
    /// 登记表
    /// </summary>
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public CourseGrade? Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}