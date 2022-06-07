using System;
using System.Collections.Generic;
using System.Text;

namespace lesson111
{
    class Student
    {
        public Student()
        {
            _totalCount++;
            No = TotalCount;
        }
        private static int _totalCount;
        public int TotalCount => _totalCount;
        public int No;
        public string FullName;
        public int Point
        {
            get => _point;
            set
            {
                if (_point >= 0 && _point <= 100)
                    _point = value;
            }
        }

        private int _point;

        
        public static bool CheckFullName(string fullname)
        {
            ;
            if (!string.IsNullOrWhiteSpace(fullname) && fullname.Length >= 7)
            {
                if (Char.IsUpper(fullname[0]))
                {
                    for (int i = 1; i < fullname.Length; i++)
                    {
                        if (!char.IsDigit(fullname[i]))
                            return false;
                    }
                    return true;
                }

            }
            return false;
        }
    }
}

