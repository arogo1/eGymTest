using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IFeedbackService
{
    public Task GetById(int id);
    public Task Delete(int id);
    public Task Create(CreateFeedbackRequest request);
    public Task Update();
    public Task<List<FeedbackDTO>> GetAll();
}

