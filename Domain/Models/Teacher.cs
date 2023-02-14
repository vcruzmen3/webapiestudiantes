using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
