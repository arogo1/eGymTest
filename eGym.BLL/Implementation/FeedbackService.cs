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
    public async Task Delete(int id)
    {
        await _unitOfWork.Feedbacks.Delete(id);
    }

    public async Task Update(UpdateFeedbackRequest request, FeedbackDTO feedback)
    {
        var updatedFeedback = _mapper.Map(request, feedback);
        await _unitOfWork.Feedbacks.Update(_mapper.Map<Feedback>(updatedFeedback));
    }

    public async Task<FeedbackDTO> GetById(int id)
    {
        var result = await _unitOfWork.Feedbacks.GetById(id);
        return _mapper.Map<FeedbackDTO>(result);
    }

    public async Task<List<FeedbackDTO>> GetAll()
    {
        var response = await _unitOfWork.Feedbacks.GetAll();
        return _mapper.Map<List<FeedbackDTO>>(response);
    }

    public async Task<List<FeedbackDTO>> GetByUser(int userId)
    {
        var response = await _unitOfWork.Feedbacks.GetWhere(x => x.AccountId.Equals(userId));
        return _mapper.Map<List<FeedbackDTO>>(response);
    }
}