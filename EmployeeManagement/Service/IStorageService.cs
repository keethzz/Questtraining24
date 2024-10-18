using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
    internal interface IStorageService
    {

        void Save(Employee employee);

        Employee GetById(string id);

        void Delete(string id);
    }
    
}
