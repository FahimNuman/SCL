
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SCL.Data;

namespace SCL.Framework
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        



    }
}

