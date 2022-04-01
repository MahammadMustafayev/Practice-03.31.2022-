using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_.Models
{
    class Student
    {
        private static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        public double Point { get; set; }
        static Student()
        {
            _id = 0;
        }
        private Student()
        {
            ++_id;
            Id = _id;
        }
        public Student(string fullName, double point):this()
        {
            FullName = fullName;
            Point = point;
        }
        public void StudentInfo(string FullName, double Point)
        {
            Console.WriteLine($"FullName:{FullName} Point:{Point}");
        }
    }
}
