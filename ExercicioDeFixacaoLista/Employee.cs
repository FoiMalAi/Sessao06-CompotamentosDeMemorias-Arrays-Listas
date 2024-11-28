using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacaoLista
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void incriseSalary(double porcentagem)
        {
            Salary += Salary * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2");
        }

    }
}
