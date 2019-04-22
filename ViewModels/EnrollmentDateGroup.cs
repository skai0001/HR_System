﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SkaikySolutions.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int EmployeeCount { get; set; }
    }
}