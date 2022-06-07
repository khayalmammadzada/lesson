using System;
using System.Collections.Generic;
using System.Text;

namespace lesson111
{
    class Group :IGroup
    {
        private string _no;
        public string No
        {
            get => _no;
            set
            {
                if (CheckGroupNo(value))
                    _no = value;
            }
        }

        Student[] IGroup.students
        { get => students; }
             


        Student[] students = new Student[0];
        int StudentLimit;




        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 4)
            {
                if (Char.IsLetter(groupNo[0]))
                {
                    for (int i = 1; i < groupNo.Length; i++)
                    {
                        if (!char.IsDigit(groupNo[i]))
                            return false;
                    }
                    return true;
                }

            }
            return false;
        }
       
        public void AddStudents(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public void CalcGroupAvg()
        {
            int avg=0;
            for(int i=0; i<students.Length; i++)
            {
                avg += students[i].Point;
            }
           int result = avg / students.Length;

           
        }

        public void GetStudentsByPoint()
        {

        }





    }
}
