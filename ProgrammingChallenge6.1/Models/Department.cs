namespace ProgrammingChallenge6._1.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public ICollection<Club> Clubs { get; set; }
    }
}
