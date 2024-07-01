using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentProfileSystem.Models.Entity;

public class StuDep
{
    [Key]
    public int DID { get; set; }
    public string DepartmentName {  get; set; }
    public ICollection<StuRec> Students { get; set; } 

}

