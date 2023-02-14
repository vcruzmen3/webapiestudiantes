using AutoMapper;
using Bussines.Implementing;
using Bussines.Infraestructure;
using Data.Context;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks;
using WebApp.models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        readonly IMapper _mapper;

        readonly IStudentCrud crud;
        public StudentController(IStudentCrud crud, IMapper mapper)
        {
            this.crud = crud;
            this._mapper = mapper;
        }

        [HttpGet]
        public List<Student> getAll()
        {
            var lista = this.crud.getAll();
            return lista;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getStudent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var studnetList = await this.crud.getAsync(id);
            if (studnetList == null)
            {
                return NotFound();
            }
            return Ok(studnetList);

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StudentPost data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student student = _mapper.Map<Student>(data);
            await this.crud.create(student);
            return Ok(student);

        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] StudentPost data)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            Student student = _mapper.Map<Student>(data);
            await this.crud.update(student);
            return Ok(student);
        }


        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] StudentPost data)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    Student student = new Student()
        //    {
        //        Id = data.Id,
        //        Lastname = data.Lastname,
        //        Name = data.Name
        //    };
        //    await this.crud.create(student);
        //    return Ok(data);

        //}
    }
}
