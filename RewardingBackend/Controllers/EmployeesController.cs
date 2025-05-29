using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RewardingBackend.Data;
using RewardingBackend.Models;
using System.Data;

namespace RewardingBackend.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public EmployeesController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("role/{role}")]
        public async Task<List<Employee>> GetEmployeesByRole(string role)
        {
            var employees = await _context.Employees
            .Where(e => e.Role == role)
            .ToListAsync();
            return employees;
        }

        [HttpGet("id/{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(Guid id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return employee;
        }

        [HttpGet("managerId/{managerId}")]
        public async Task<List<Employee>> GetSubordinates(Guid managerId)
        {
            var employees = await _context.Employees
            .Where(e => e.ManagerId == managerId)
            .ToListAsync();
            return employees;
        }
    }
}