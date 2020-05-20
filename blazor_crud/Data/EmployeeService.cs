using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_crud.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;
        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }
        //CRUD Operation

        //Get All Employee
        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

        //Insert Employe Info
        public string Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Save Success";
        }

        //Get Employee By Id
        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }

        //Update Employee Info
        public string UpdateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Update Success";
        }

        //Delete Employee Info
        public string DeleteEmployee(EmployeeInfo objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delete Success";
        }
    }
}
