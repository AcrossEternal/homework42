using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;


namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //构建学生数据
            var students = new List<Student> {
                new Student { Name="王贵",EnrollmentDate=DateTime.Parse("2019-1-3")},
                new Student { Name="王富贵",EnrollmentDate=DateTime.Parse("2017-2-3")},
                new Student { Name="大大大",EnrollmentDate=DateTime.Parse("2029-3-3")},
                new Student { Name="王1贵",EnrollmentDate=DateTime.Parse("2029-1-3")},
                new Student { Name="王11",EnrollmentDate=DateTime.Parse("2007-5-3")},
                new Student { Name="大2大",EnrollmentDate=DateTime.Parse("2009-9-3")}
            };
            //将学生数据加入实体集

            students.ForEach(st => context.Students.Add(st));
            context.SaveChanges();
            //构建课程数据
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="C#",Credits=3,},
            new Course{CourseID=4022,Title="WEB开发",Credits=3,},
            new Course{CourseID=4041,Title="SQL数据库",Credits=3,},
            new Course{CourseID=1045,Title="软件工程",Credits=4,},
            new Course{CourseID=3141,Title="python",Credits=4,},
            new Course{CourseID=2021,Title="Unity 3D",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };

            //将课程数据加入实体集
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            //构建注册数据
            var enrollments = new List<Enrollment>
            //将注册数据加入实体类
             {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}