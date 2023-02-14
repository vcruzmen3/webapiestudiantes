using Data.Context;
using Data.Repository.Infraestructure;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class StudentRepository : IStudentRepository
    {


        DbContextSchool _db;

         public StudentRepository(DbContextSchool db)
        {
            _db = db;
        }
       public async Task<Student>  Create(Student student)
        {
            student.CreateAt= DateTime.Now;
            this._db.Students.Add(student);
            await _db.SaveChangesAsync();
            return student;

         }

        bool IStudentRepository.delete(int id)
        {
            throw new NotImplementedException();
        }

        Student IStudentRepository.get(int id)
        {
            throw new NotImplementedException();
        }

       public List<Student>  getAll()
            {
          
                var result =  _db.Students.ToList<Student>();
            return result.ToList();

        }

        Task<Student> IStudentRepository.getAsync(int id)
        {
            throw new NotImplementedException();
        }

        async Task<Student> IStudentRepository.update(Student student)
        {
            student.UpdateAt= DateTime.Now;
            this._db.Students.Update(student);
            await this._db.SaveChangesAsync();
            return student;

                }
    }
}
