using System.ComponentModel.DataAnnotations;


namespace University.BL.DTOs
{
    public class OfficeAssignmentDTOs
    {
        [Required]
        public int InstructorID { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        //navs dtos
        public InstructorDTOs Instructor { get; set; }
       
      
}
}
