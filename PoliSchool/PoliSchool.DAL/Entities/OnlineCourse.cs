﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace PoliSchool.DAL.Entities
{
    [Table("OnlineCourse")]
    public partial class OnlineCourse
    {
        public int CourseId { get; set; }
        public string? Url { get; set; }

       
    }
}