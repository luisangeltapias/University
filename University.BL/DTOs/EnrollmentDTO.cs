
namespace University.BL.DTOs
{
    public class EnrollmentDTO
{
    
    public int EnrollmentID { get; set; }

  
    public int CourseID { get; set; }

    public int StudentID { get; set; }

    //navs

    public CourseDTO Course  { get; set; }
    public StudentDTOs Student { get; set; }
}
}

