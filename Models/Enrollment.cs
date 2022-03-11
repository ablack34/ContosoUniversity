using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        //Foreign Key
        public int CourseID { get; set; }
        //In the database, an Enrollment row is related to a Student row if its StudentID column contains the student's ID value.
        //StudentID is a foreign key in the Enrollment table.
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        //Navigation property
        public Course Course { get; set; }
        //Navigation property
        //An Enrollment entity is associated with one Student entity, so the property contains a single Student entity.
        public Student Student { get; set; }
    }
}