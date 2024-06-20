
using SchoolAppGFive.DAL.Models;

namespace SchoolAppGFive.DAL.Interfaces
{
    public interface IDepartmentDb
    {
        List<DepartmentModel> GetDepartments();

        DepartmentModel GetDepartment(int departmentId);

        void SaveDeparment(DepartmentAddModel departmentAdd);
        void UpdateDepartment(DepartmentUpdateModel departmentAdd);
        void RemoveDeparment(DepartmentRemoveModel departmentAdd);
    }
}
