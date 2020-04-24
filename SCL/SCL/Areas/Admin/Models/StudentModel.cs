using Autofac;
using SCL.Areas.Admin.Data;
using SCL.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCL.Areas.Admin.Models
{
    public class StudentModel
    {
        public string StudentName { get; set; }
        public DateTime DateofBirth { get; set; }
        public void CreateStudent()
        {
            var context = Startup.AutofacContainer.Resolve<StudentContext>();
            context.Students.Add(new Student
            {
                StudentName = this.StudentName,
                DateofBirth = this.DateofBirth,

            });



            context.SaveChanges();
            context.Dispose();
        }
    }
}