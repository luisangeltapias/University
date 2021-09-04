using System.ComponentModel.DataAnnotations;
namespace University.BL.DTOs
{
    public class CourseDTO
    {
        [Required()]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
}
