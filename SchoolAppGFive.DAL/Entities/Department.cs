﻿using SchoolAppGFive.DAL.Core;

namespace SchoolAppGFive.DAL.Entities
{
    public class Department : BaseEntity
    {
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator {  get; set; }

    }
}
