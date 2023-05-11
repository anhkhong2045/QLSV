using Microsoft.AspNetCore.Mvc;
using QLSV1.Model;
using System;
using System.Collections.Generic;

namespace QLSV1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelationshipController : ControllerBase
    {
        // Thêm nhiều sinh viên cùng lúc vào lớp học
        private readonly ILogger<RelationshipController> _logger;

        public RelationshipController(ILogger<RelationshipController> logger)
        {
            _logger = logger;
        }
        [HttpPost("class/{classId}/students")] 
        public IActionResult AddStudentsToClass(int classId, List<int> studentIds)
        {
            try
            {
                // Xử lý logic thêm nhiều sinh viên vào lớp trong database 
                return Ok();
            }
            catch (Exception ex)
            {
                // Log lỗi
                _logger.LogError(ex, "Lỗi xảy ra khi thêm sinh viên vào lớp");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }

        // Xoá lớp bao gồm xoá sinh viên trong lớp
        [HttpDelete("{classId}")]
        public IActionResult DeleteClassWithStudents(int classId)
        {
            try
            {
                // Xử lý logic xoá lớp môn học và tất cả sinh viên trong lớp trong database
                return Ok();
            }
            catch (Exception ex)
            {
                // Log lỗi
                _logger.LogError(ex, "Lỗi xảy ra khi xoá lớp và sinh viên trong lớp");

                // Trả về HTTP status code 500 và thông báo lỗi cho client
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi trong quá trình xử lý");
            }
        }
    }
}
