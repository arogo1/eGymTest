using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class EmployeeService : IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

	public async Task Create(CreateEmployeeRequest request)
	{
        await _unitOfWork.Employees.Insert(_mapper.Map<Employee>(request));
	}

    public async Task Delete(int id)
    {
        await _unitOfWork.Employees.Delete(id);
    }

    public async Task Update(UpdateAccountRequest request, EmployeeDTO employee)
    {
        var updatedEmployee = _mapper.Map(request, employee);
        await _unitOfWork.Employees.Update(_mapper.Map<Employee>(updatedEmployee));
    }

    public async Task<EmployeeDTO> GetById(int id)
    {
        var result = await _unitOfWork.Employees.GetById(id);
        return _mapper.Map<EmployeeDTO>(result);
    }
}

