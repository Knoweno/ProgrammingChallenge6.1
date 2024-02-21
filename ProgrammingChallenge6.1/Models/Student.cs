namespace ProgrammingChallenge6._1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public ICollection<Enrolment> Enrolments { get; set; }
    }
}
