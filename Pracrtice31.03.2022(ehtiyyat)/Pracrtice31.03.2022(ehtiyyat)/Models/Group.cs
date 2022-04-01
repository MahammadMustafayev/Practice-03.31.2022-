using System;
using System.Collections.Generic;
using System.Text;

namespace Pracrtice31._03._2022_ehtiyyat_.Models
{
    class Group
    {
        public int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (_studentLimit >= 5 || _studentLimit <= 18)
                {
                    _studentLimit = value;
                }
            }
        }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        private Student[] _students = new Student[0];
        public bool CheckGroupNo(string groupNo)
        {

            if (groupNo.Length == 5 && !String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo))
            {
                int IsUpper = 0;
                int IsDigit = 0;
                for (int i = 0; i < groupNo.Length; i++)
                {
                    if (i < 2)
                    {
                        if (char.IsUpper(groupNo[i])) IsUpper++;
                    }
                    else if (IsUpper == 2 && i >= 2)
                    {
                        if (char.IsDigit(groupNo[i])) IsDigit++;
                    }
                    else
                    {
                        return false;
                    }
                    if (IsUpper == 2 && IsDigit == 3) return true;
                }
            }
            return false;
        }
        public void AddStudents(Student student)
        {
            if (_students.Length >= StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
                Console.WriteLine(student);
            }
            throw new NotFoundException("Elave edile bilmedi");
        }
        public Student GetStudent(int? id)
        {
            if (id != null)
            {
                foreach (Student item in _students)
                {
                    if (item.Id.Equals(id)) return item;
                }
            }
            else
            {
                throw new NullReferenceException("Id null ola bilmez");
            }
            throw new NotFoundException("Not-found student");
        }
        public Student[] GetAllStudents()
        {
            return _students;
        }
    }
}
