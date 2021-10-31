using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPST
{
    class Student:Person
    {
        public string Study()
        {
            return "I'm studying";
        }
        public string ShowAge(byte x)
        {
            return $"My age is: {x} years old";
        }
    }
}
