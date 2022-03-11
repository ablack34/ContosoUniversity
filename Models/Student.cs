namespace ContosoUniversity.Models
{
    public class Student
    {
        //The ID property becomes the primary key column of the database table that corresponds to this class.
        //By default, EF Core interprets a property that's named ID or classnameID as the primary key.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation properties hold other entities that are related to this entity.
        //In this case, the Enrollments property of a Student entity holds all of the Enrollment entities that are related to that Student.
        //For example, if a Student row in the database has two related Enrollment rows,
        //the Enrollments navigation property contains those two Enrollment entities.
        //The Enrollments property is defined as ICollection<Enrollment> because there may be multiple related Enrollment entities.
        //Student may have multiple Enrollment entities
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}