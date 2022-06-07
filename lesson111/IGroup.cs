using System;
using System.Collections.Generic;
using System.Text;

namespace lesson111
{
    interface IGroup
    {
        Student[] students { get; }
        void AddStudents(Student student);
        void CalcGroupAvg();
    }
}
