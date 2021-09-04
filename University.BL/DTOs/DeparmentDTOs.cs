using System;
using System.ComponentModel.DataAnnotations;
namespace University.BL.DTOs
{
    public class DeparmentDTO
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; }
        public DateTime StartDate { get; set; }

        public int InstructorID { get; set; }
 
    }
}
