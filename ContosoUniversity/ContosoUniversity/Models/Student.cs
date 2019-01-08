using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name ="姓名")]
        public string Name { get; set; }

        [Display(Name = "注册日期")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "头像")]
        public string Image { get; set; }

        [Display(Name = "选课信息")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}