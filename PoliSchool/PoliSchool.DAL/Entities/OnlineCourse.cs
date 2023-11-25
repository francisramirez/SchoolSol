﻿

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoliSchool.DAL.Entities
{
    [Table("OnlineCourse")]
    public partial class OnlineCourse
    {
        [Key]
        public int CourseId { get; set; }
        public string? Url { get; set; }

       
    }
}