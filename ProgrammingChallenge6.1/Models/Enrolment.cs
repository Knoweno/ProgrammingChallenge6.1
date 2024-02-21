using System.ComponentModel.DataAnnotations;

namespace ProgrammingChallenge6._1.Models
{
    public class Enrolment
    {
        [Key]
        public int EnrolmentID { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int clubId { get; set; }
        public Club club { get; set; }
    }
}
