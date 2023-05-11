using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace QLSV1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassController : ControllerBase 
    {
        private readonly ILogger<ClassController> _logger;

        public ClassController(ILogger<ClassController> logger)
        {
            _logger = logger;
        }

         // Thêm lớp môn học
        [HttpPost]
        public IActionResult AddClass([FromBody] Dictionary<string, string> data)
        {
            try
            {
                // Xử lý logic thêm lớp môn học vào database 
                return Ok();
            }
            catch (Exception ex)
            {
                // Log lỗi
                _logger.LogError(ex, "Lỗi xảy ra khi thêm lớp môn học");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }

        // Cập nhật thông tin lớp môn học theo id
        [HttpPut("{id}")]
        public IActionResult UpdateClass(int id, [FromBody] Dictionary<string, string> data)
        {
            try
            {
                // Xử lý logic cập nhật thông tin lớp môn học trong database
                return Ok();
            }
            catch (Exception ex)
            {
                // Log lỗi
                _logger.LogError(ex, "Lỗi xảy ra khi cập nhật thông tin lớp môn học");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }

        // Lấy thông tin lớp môn học theo id
        [HttpGet("{id}")]
        public IActionResult GetClass(int id)
        {
            try
            {
                // Xử lý logic lấy thông tin lớp môn học từ database và trả về
                return Ok(new { id = id, name = "Class A" });
            }
            catch (Exception ex)
            {
                // Log lỗi
                _logger.LogError(ex, "Lỗi xảy ra khi lấy thông tin lớp môn học");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }

        // Xoá lớp môn học theo id
        [HttpDelete("{id}")]
        public IActionResult DeleteClass(int id)
        {
            try
            {
                // Xử lý logic xoá lớp môn học trong database
                return Ok();
            }
            catch (Exception ex)
            {
                // Log lỗi
                _logger.LogError(ex, "Lỗi xảy ra khi xoá lớp môn học");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }

        // Lấy danh sách lớp môn học chia trang
        [HttpGet("page/{pageNumber}")]
        public IActionResult GetClassesByPage(int pageNumber)
        {
            try
            {
                // Xử lý logic lấy danh sách lớp môn học từ database và phân trang
                List<object> classes = new List<object>()
                {
                    new { id = 1, name = "Class A" },
                    new { id = 2, name = "Class B" },
                    new { id = 3, name = "Class C" }
                };
                return Ok(classes);
            }
            catch (Exception ex)
            {
                // Log lỗi
               _logger.LogError(ex, "Lỗi xảy ra khi lấy danh sách sinh viên trong lớp");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }
    }
}
