using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CTS_CC.Models;

namespace CTS_CC.DbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(Employee model)
        {
            using (var _context = new ApplicationDbContext())
            {
                Employee employee = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code,
                };
                if(model.Address != null)
                {
                    employee.Address = new Address()
                    {
                        Details = model.Address.Details,
                        State = model.Address.State,
                        Country = model.Address.Country,
                    };
                }
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return employee.Id;
            }
        }
    }
}