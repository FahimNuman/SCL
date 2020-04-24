using System;
using System.Collections.Generic;
using System.Text;

namespace SCL.Framework
{
    public interface ISchoolUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        
    }
}
