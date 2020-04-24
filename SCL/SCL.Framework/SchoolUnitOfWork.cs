using Microsoft.EntityFrameworkCore;
using SCL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCL.Framework
{
    public class SchoolUnitOfWork : UnitOfWork<DbContext>, ISchoolUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        
        public SchoolUnitOfWork(string connectionString, string migrationAssemblyName) :
            base(connectionString, migrationAssemblyName)
        {
            StudentRepository = new StudentRepository(_dbContext);
        }
    }
}
