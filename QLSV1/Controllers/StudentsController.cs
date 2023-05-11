using Microsoft.AspNetCore.Mvc;
using QLSV1.Model;
using System.Collections.Generic;

namespace QLSV1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        // Thêm sinh viên
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                // Xử lý logic thêm sinh viên vào database 
                return Ok();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi dưới dạng JSON
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Lỗi hệ thống: " + ex.Message });
            }
        }

        // Cập nhật thông tin sinh viên theo id
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            try
            {
                // Xử lý logic cập nhật thông tin sinh viên trong database
                return Ok();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi dưới dạng JSON
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Lỗi hệ thống: " + ex.Message });
            }
        }

        // Lấy thông tin chi tiết sinh viên theo id
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            try
            {
                // Xử lý logic lấy thông tin sinh viên từ database và trả về
                return Ok(new Student());
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi dưới dạng JSON
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Lỗi hệ thống: " + ex.Message });
            }
        }

        // Xoá sinh viên theo id
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                // Xử lý logic xoá sinh viên trong database
                return Ok();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi dưới dạng JSON
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Lỗi hệ thống: " + ex.Message });
            }
        }

        // Lấy danh sách sinh viên chia trang
        [HttpGet("page/{pageNumber}")]
        public IActionResult GetStudentsByPage(int pageNumber)
        {
            try
            {
                // Xử lý logic lấy danh sách sinh viên từ database và phân trang
                List<Student> students = new List<Student>();
                return Ok(students);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi dưới dạng JSON
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Lỗi hệ thống: " + ex.Message });
            }
        }
    }
}

