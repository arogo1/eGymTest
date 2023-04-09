using AutoMapper;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class PaymentService : IPaymentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

	public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

    public async Task Create(PaymentRequest request)
    {
        await _unitOfWork.Payments.Insert(_mapper.Map<Payment>(request));
    }

    public async Task Delete(int id)
    {

    }

    public async Task Update()
    {

    }

    public async Task GetById(int id)
    {

    }
}

