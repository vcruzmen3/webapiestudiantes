using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace WebApp.Data
{
    public partial class schooldbContext : DbContext
    {
        public schooldbContext()
        {
        }
    }
}
//    public schooldbContext(DbContextOptions<schooldbContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Course> Courses { get; set; }
//    public virtual DbSet<Group> Groups { get; set; }
//    public virtual DbSet<GroupStudent> GroupStudents { get; set; }
//    public virtual DbSet<Student> Students { get; set; }
//    public virtual DbSet<Teacher> Teachers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        if (!optionsBuilder.IsConfigured)
//        {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//            optionsBuilder.UseSqlServer("cnn");
//        }
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

//        modelBuilder.Entity<Course>(entity =>
//        {
//            entity.ToTable("Course");

//            entity.Property(e => e.Id).HasColumnName("id");

//            entity.Property(e => e.CreateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("create_at");

//            entity.Property(e => e.Name)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasColumnName("name");

//            entity.Property(e => e.UpdateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("update_at");
//        });

//        modelBuilder.Entity<Group>(entity =>
//        {
//            entity.Property(e => e.Id).HasColumnName("id");

//            entity.Property(e => e.CourseId).HasColumnName("course_id");

//            entity.Property(e => e.CreateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("create_at");

//            entity.Property(e => e.Name)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("name");

//            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

//            entity.Property(e => e.UpdateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("update_at");

//            entity.HasOne(d => d.Course)
//                .WithMany(p => p.Groups)
//                .HasForeignKey(d => d.CourseId)
//                .HasConstraintName("FK__Groups__course_i__5070F446");

//            entity.HasOne(d => d.Teacher)
//                .WithMany(p => p.Groups)
//                .HasForeignKey(d => d.TeacherId)
//                .HasConstraintName("FK__Groups__teacher___4F7CD00D");
//        });

//        modelBuilder.Entity<GroupStudent>(entity =>
//        {
//            entity.ToTable("GroupStudent");

//            entity.Property(e => e.Id).HasColumnName("id");

//            entity.Property(e => e.CreateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("create_at");

//            entity.Property(e => e.Grade).HasColumnName("grade");

//            entity.Property(e => e.GroupsId).HasColumnName("groups_id");

//            entity.Property(e => e.StudentId).HasColumnName("student_id");

//            entity.Property(e => e.UpdateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("update_at");

//            entity.HasOne(d => d.Groups)
//                .WithMany(p => p.GroupStudents)
//                .HasForeignKey(d => d.GroupsId)
//                .HasConstraintName("FK__GroupStud__group__534D60F1");

//            entity.HasOne(d => d.Student)
//                .WithMany(p => p.GroupStudents)
//                .HasForeignKey(d => d.StudentId)
//                .HasConstraintName("FK__GroupStud__stude__5441852A");
//        });

//        modelBuilder.Entity<Student>(entity =>
//        {
//            entity.ToTable("Student");

//            entity.Property(e => e.Id).HasColumnName("id");

//            entity.Property(e => e.CreateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("create_at");

//            entity.Property(e => e.Lastname)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasColumnName("lastname");

//            entity.Property(e => e.Name)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasColumnName("name");

//            entity.Property(e => e.UpdateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("update_at");
//        });

//        modelBuilder.Entity<Teacher>(entity =>
//        {
//            entity.ToTable("Teacher");

//            entity.Property(e => e.Id).HasColumnName("id");

//            entity.Property(e => e.CreateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("create_at");

//            entity.Property(e => e.Lastname)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasColumnName("lastname");

//            entity.Property(e => e.Name)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasColumnName("name");

//            entity.Property(e => e.UpdateAt)
//                .HasColumnType("datetime")
//                .HasColumnName("update_at");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
//}