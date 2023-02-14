using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupStudents = new HashSet<GroupStudent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TeacherId { get; set; }
        public int? CourseId { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<GroupStudent> GroupStudents { get; set; }
    }
}
