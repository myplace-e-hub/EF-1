using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace EF_1
{
    class Employee
    {
        [Key]
        public int EmployeeId { set; get; }
        public string EmployeeName { set; get; }
        public decimal Salary { set; get; }
    }

    class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base(@"Data Source=DESKTOP-GSLLMHA;Initial Catalog=company;Integrated Security=True")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Employee> employees = db.Employees.ToList();
           
            foreach (var employee in employees)
            {
                Console.WriteLine("EmployeeID:{0}\t\tEmployee Name:{1}\t\tSalary{2}", employee.EmployeeId,employee.EmployeeName,employee.Salary);
            }

            Console.ReadKey();
        }
    }
}
