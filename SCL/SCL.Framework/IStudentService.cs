﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SCL.Framework
{
    public interface IStudentService
    {
        IList<Student> GetStudents(int pageIndex, int pageSize, string searchText = null, string sortText = null);
        void AddStudent(Student student);
        void EditStudent(Student student);
        Student GetStudent(int Id);
    }
}
