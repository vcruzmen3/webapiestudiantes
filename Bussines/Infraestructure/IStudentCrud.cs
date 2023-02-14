using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Infraestructure
{
    public interface IStudentCrud
    {
        public List<Student> getAll();
        public Student get(int id);

        public Task<Student> getAsync(int id);

        public Task<Student> create(Student student);
        
        public Task<Student> update(Student student);
        public bool delete(int id);
    }
}
