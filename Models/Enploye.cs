using WinOverview.Models.Base;

namespace WinOverview.Models;

public class Enploye: BaseEntity
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public PositionType Position { get; set; }
    public DateTime HireDate { get; set; }
}

public enum PositionType
{
    Manager,
    Developer,
    Designer,
    Tester,
    Support
}





