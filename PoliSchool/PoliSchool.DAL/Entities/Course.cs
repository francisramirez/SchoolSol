﻿

using PoliSchool.DAL.Core;

namespace PoliSchool.DAL.Entities
{
    public partial class Course : BaseEntity
    {
       
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
              

    }
}