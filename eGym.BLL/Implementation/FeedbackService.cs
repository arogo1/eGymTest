using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class FeedbackService : IFeedbackService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Create(CreateFeedbackRequest request)
    {
        await _unitOfWork.Feedbacks.Insert(_mapper.Map<Feedback>(request));
    }

    //Do we need this??? delete, update, getById
    public async Task Delete(int id)
    {
        await _unitOfWork.Feedbacks.Delete(id);
    }

    public async Task Update()
    {

    }

    public async Task GetById(int id)
    {

    }

    public async Task<List<FeedbackDTO>> GetAll()
    {
        var response = await _unitOfWork.Feedbacks.GetAll();
        return _mapper.Map<List<FeedbackDTO>>(response);
    }
}

