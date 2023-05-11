using System.ComponentModel.DataAnnotations;

namespace QLSV1.Model
{
    public class Class
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(5)]
        public string ClassCode { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxStudents { get; set; }
    }
}
