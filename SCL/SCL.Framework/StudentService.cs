using System;
using System.Collections.Generic;
using System.Text;

namespace SCL.Framework
{
    public class StudentService : IStudentService
    {
        private ISchoolUnitOfWork _schoolUnitOfWork;

        public StudentService(ISchoolUnitOfWork schoolUnitOfWork)
        {
            _schoolUnitOfWork = schoolUnitOfWork;
        }

        public(IList<Student> record,int total,int totaldisplay)GetStudents(int pageIndex, int pageSize, string searchText = null, string sortText = null)
        {
            throw new NotImplementedException();
        }

        public Student Add(Student student)
        {
            _schoolUnitOfWork.StudentRepository.AddStudent(student);
            return student;
        }

        IList<Student> IStudentService.GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
