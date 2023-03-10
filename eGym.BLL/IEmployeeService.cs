using System;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IEmployeeService
{
    public Task<EmployeeDTO> GetById(int id);
    public Task Delete(int id);
    public Task Create(CreateEmployeeRequest request);
    public Task Update(UpdateAccountRequest request, EmployeeDTO employee);
}

