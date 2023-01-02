using asp.net_app.Entities;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace asp.net_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IConfiguration _configuration;
        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("{employeeId}")]
        public IActionResult GetUserById([FromRoute] Guid employeeId)
        {
            Console.WriteLine(_configuration.GetConnectionString("MySQL"));
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("MySQL")))
            {
                var parameters = new DynamicParameters() {};

                parameters.Add("v_EmployeeId", employeeId);

                var result = connection.QueryFirstOrDefault<Employee>("Proc_employee_GetById", parameters, commandType: System.Data.CommandType.StoredProcedure);

                return Ok(result);
            }
        }
    }
}
