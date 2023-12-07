using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork13
{
    class Employee
    {
        public string FullName;
        public string Gender;
        public int Age;
        public int Salary;

        public Employee(string data)
        {
            var parts = data.Split(',');
            FullName = $"{parts[0]} {parts[1]} {parts[2]}";
            Gender = parts[3];
            Age = int.Parse(parts[4]);
            Salary = int.Parse(parts[5]);
        }

        public override string ToString()
        {
            return $"{FullName}, Гендер: {Gender}, Возраст: {Age}, Зарплата: {Salary}";
        }
    }
}
