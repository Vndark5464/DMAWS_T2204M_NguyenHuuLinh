using DMAWS_T2204M_NguyenHuuLinh.Models;

namespace DMAWS_T2204M_NguyenHuuLinh.DTOs
{
    public class ProjectEmployee
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public string Tasks { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual Project Projects { get; set; }
    }
}
