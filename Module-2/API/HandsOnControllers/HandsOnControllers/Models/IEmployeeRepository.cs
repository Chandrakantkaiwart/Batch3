﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnControllers.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int eid);
        Employee GetEmployee(string name);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int eid);
    }
}
