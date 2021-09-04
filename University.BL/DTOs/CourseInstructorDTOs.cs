using System.ComponentModel.DataAnnotations;
using University.BL.Models;

namespace University.BL.DTOs
{
    
    public class CourseInstructorDTO
    {
        [Required()]
        public int ID { get; set; }

        public int CourseID { get; set; }

      
        public int InstructorID { get; set; }

        //navs
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

    }
}
