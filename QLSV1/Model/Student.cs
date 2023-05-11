using System.ComponentModel.DataAnnotations;

namespace QLSV1.Model
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string StudentCode { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
