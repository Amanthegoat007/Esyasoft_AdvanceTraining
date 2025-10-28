using Assignment2_RepositoryPattern.DTOs;
using Assignment2_RepositoryPattern.Models;
using Assignment2_RepositoryPattern.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_RepositoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // all endpoints require authentication unless overridden
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        public EmployeesController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _repo.GetAllAsync();
            var dtos = employees.Select(e => new EmployeeDto
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FullName,
                Department = e.Department,
                Email = e.Email
            });
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var e = await _repo.GetByIdAsync(id);
            if (e == null) return NotFound();
            var dto = new EmployeeDto
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FullName,
                Department = e.Department,
                Email = e.Email
            };
            return Ok(dto);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> Create(CreateEmployeeDto dto)
        {
            var emp = new Employee
            {
                FullName = dto.FullName,
                Department = dto.Department,
                Email = dto.Email,
               
            };
            await _repo.AddAsync(emp);
            return CreatedAtAction(nameof(GetById), new { id = emp.EmployeeId }, new { emp.EmployeeId });
        }

        [HttpPut("{id:int}")]
        //[Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> Update(int id, UpdateEmployeeDto dto)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.FullName = dto.FullName;
            existing.Department = dto.Department;
            existing.Email = dto.Email;

            await _repo.UpdateAsync(existing);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        //[Authorize(Roles = "Admin")] // only Admin can delete
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return NotFound();

            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}
