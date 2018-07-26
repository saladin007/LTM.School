using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LTM.School.Application.enumType;

namespace LTM.School.Core.Models
{
    public class Course
    {
        //Data Annotations(注解的方式)
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// 学分
        /// </summary>
        public int Credits { get; set; }

        public CourseGrade Grade { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}