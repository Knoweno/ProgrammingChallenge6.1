using Microsoft.AspNetCore.Mvc.Rendering;
using ProgrammingChallenge6._1.Models;


namespace ProgrammingChallenge6._1.ViewModels
{

public class ClubAddClubViewModel
    {
    public Club Club { get; set; }
    public Department Department { get; set; }
    public SelectList DepartmentList { get; set; }

}
}
