using System.ComponentModel.DataAnnotations;

namespace AdminDBHandler.Models.Dept_Level_Term
{
    public class Department
    {
        [Key]
        public int? DeptId { get; set; }
        public string? DeptName { get; set; }
    }
}
