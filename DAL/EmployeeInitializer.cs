/*
 @auther: Hasan Skaiky
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SkaikySolutions.Models;

namespace SkaikySolutions.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
            new Employee{PRI=13562,FirstName="Hasan",LastName="Skaiky",EnrollmentDate=DateTime.Parse("1999-10-02")},
            new Employee{PRI=12472,FirstName="Juan",LastName="Gonzales",EnrollmentDate=DateTime.Parse("2012-09-10")},
            new Employee{PRI=16543,FirstName="Dino",LastName="Zidan",EnrollmentDate=DateTime.Parse("2000-01-05")},
            new Employee{PRI=2653,FirstName="Mousa",LastName="Abdul",EnrollmentDate=DateTime.Parse("1996-07-04")},
            new Employee{PRI=95781,FirstName="Hiu",LastName="Li",EnrollmentDate=DateTime.Parse("2014-01-09")},
            new Employee{PRI=74321,FirstName="Joane",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-12-03")},
            new Employee{PRI=23166,FirstName="John",LastName="Doe",EnrollmentDate=DateTime.Parse("2013-08-02")},
            new Employee{PRI=12456,FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-03-01")}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}