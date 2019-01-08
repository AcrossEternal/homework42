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
            // 构建学生数据
            var students = new List<Student>
            {
            new Student{Name="无名1",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{Name="无名2",EnrollmentDate=DateTime.Parse("2006-09-01")},
            new Student{Name="无名3",EnrollmentDate=DateTime.Parse("2007-09-01")},
            new Student{Name="无名4",EnrollmentDate=DateTime.Parse("2008-09-01")},
            new Student{Name="无名5",EnrollmentDate=DateTime.Parse("2009-09-01")},
            new Student{Name="无名6",EnrollmentDate=DateTime.Parse("2010-09-01")},
            new Student{Name="无名7",EnrollmentDate=DateTime.Parse("2011-09-01")},
            new Student{Name="无名8",EnrollmentDate=DateTime.Parse("2012-09-01")}
            };
            //将学生数据加入实体集,并保存状态
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            // 构建课程数据
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="C#语言入门",Credits=3,},
            new Course{CourseID=4022,Title="MIS",Credits=3,},
            new Course{CourseID=4041,Title="web发开",Credits=3,},
            new Course{CourseID=1045,Title="信息处理",Credits=4,},
            new Course{CourseID=3141,Title="算法设计与分析",Credits=4,},
            new Course{CourseID=2021,Title="计算机维修",Credits=3,},
            new Course{CourseID=2042,Title="计算机组装",Credits=4,}
            };
            //将课程数据加入实体集,并保存状态
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            // 构建注册数据
            var enrollments = new List<Enrollment>
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
            //将注册数据加入实体集,并保存状态
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}