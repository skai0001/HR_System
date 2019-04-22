/*
 @auther: Hasan Skaiky
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkaikySolutions.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int PRI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}