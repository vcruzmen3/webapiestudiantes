using Bussines.Infraestructure;
using Data.Repository.Infraestructure;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Implementing
{
    public class StudentCrud : IStudentCrud
    {
        
        IStudentRepository repository;
        public StudentCrud(IStudentRepository repo)
        {
            this.repository = repo;
        }

        public async Task<Student> create(Student student)
        {
            var result = await this.repository.Create(student);
            return result;
        }

        public async Task<Student> update(Student student)
        {
            return await this.repository.update(student);
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student get(int id)
        {
            throw new NotImplementedException();
        }

        public  List<Student> getAll()
        {
            return this.repository.getAll();
            
        }

        private List<Student> Ok()
        {
            throw new NotImplementedException();
        }

        public Task<Student> getAsync(int id)
        {
            throw new NotImplementedException();
        }


        List<Student> IStudentCrud.getAll()
        {
            return this.repository.getAll();
        }

  

    }
}
