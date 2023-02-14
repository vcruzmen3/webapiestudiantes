using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Infraestructure
{
    public interface IStudentRepository
    {

            public List<Student> getAll();
            public Student get(int id);

            public Task<Student> getAsync(int id);

            public Task<Student> Create(Student student);

            public Task<Student> update(Student student);
            public bool delete(int id);
        
    }
}
