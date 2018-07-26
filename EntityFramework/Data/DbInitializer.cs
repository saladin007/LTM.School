using LTM.School.Application.enumType;
using LTM.School.Core.Models;
using System;
using System.Linq;

namespace LTM.School.EntityFramework.Data
{
    public class DbInitializer
    {
        public static void Initializer(SchoolDbContext context) {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;//返回不执行
            }

            #region 添加种子学生信息

            var students = new[]
            {
                new Student {RealName = "龙傲天", EnrollmentDate = DateTime.Parse("2005-09-01")},
                new Student {RealName = "王尼玛", EnrollmentDate = DateTime.Parse("2002-09-01")},
                new Student {RealName = "张全蛋", EnrollmentDate = DateTime.Parse("2003-09-01")},
                new Student {RealName = "叶良辰", EnrollmentDate = DateTime.Parse("2002-09-01")},
                new Student {RealName = "和珅", EnrollmentDate = DateTime.Parse("2002-09-01")},
                new Student {RealName = "纪晓岚", EnrollmentDate = DateTime.Parse("2001-09-01")},
                new Student {RealName = "李逍遥", EnrollmentDate = DateTime.Parse("2003-09-01")},
                new Student {RealName = "王小虎", EnrollmentDate = DateTime.Parse("2005-09-01")}
            };
            foreach (var s in students)
                context.Students.Add(s);
            context.SaveChanges();

            #endregion
            var courses = new[]
            {
                new Course
                {
                    CourseId = 1050,
                    Title = "数学",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 4022,
                    Title = "政治",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 4041,
                    Title = "物理",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 1045,
                    Title = "化学",
                    Credits = 4
                },
                new Course
                {
                    CourseId = 3141,
                    Title = "生物",
                    Credits = 4
                },
                new Course
                {
                    CourseId = 2021,
                    Title = "英语",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 2042,
                    Title = "历史",
                    Credits = 4
                }
            };
            foreach (var c in courses)
                context.Courses.Add(c);
            context.SaveChanges();
            var enrollments = new[]
            {
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "龙傲天").Id,
                    CourseId = courses.Single(c => c.Title == "数学").CourseId,
                    Grade = CourseGrade.A
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "龙傲天").Id,
                    CourseId = courses.Single(c => c.Title == "政治").CourseId,
                    Grade = CourseGrade.C
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "龙傲天").Id,
                    CourseId = courses.Single(c => c.Title == "物理").CourseId,
                    Grade = CourseGrade.D
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "王尼玛").Id,
                    CourseId = courses.Single(c => c.Title == "物理").CourseId,
                    Grade = CourseGrade.F
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "王尼玛").Id,
                    CourseId = courses.Single(c => c.Title == "化学").CourseId
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "王尼玛").Id,
                    CourseId = courses.Single(c => c.Title == "生物").CourseId
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "叶良辰").Id,
                    CourseId = courses.Single(c => c.Title == "英语").CourseId,
                    Grade = CourseGrade.A
                }, new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "叶良辰").Id,
                    CourseId = courses.Single(c => c.Title == "历史").CourseId,
                    Grade = CourseGrade.D
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "张全蛋").Id,
                    CourseId = courses.Single(c => c.Title == "英语").CourseId,
                    Grade = CourseGrade.B
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "张全蛋").Id,
                    CourseId = courses.Single(c => c.Title == "数学").CourseId,
                    Grade = CourseGrade.A
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "纪晓岚").Id,
                    CourseId = courses.Single(c => c.Title == "英语").CourseId
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "王小虎").Id,
                    CourseId = courses.Single(c => c.Title == "生物").CourseId
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "和珅").Id,
                    CourseId = courses.Single(c => c.Title == "物理").CourseId,
                    Grade = CourseGrade.A
                },
                new Enrollment
                {
                    StudentId = students.Single(s => s.RealName == "和珅").Id,
                    CourseId = courses.Single(c => c.Title == "英语").CourseId
                }
            };
            foreach (var e in enrollments)
                context.Enrollments.Add(e);
            context.SaveChanges();
        }
    }
}