using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class GroupStudent
    {
        public int Id { get; set; }
        public int? GroupsId { get; set; }
        public int? StudentId { get; set; }
        public double? Grade { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Group Groups { get; set; }
        public virtual Student Student { get; set; }
    }
}
