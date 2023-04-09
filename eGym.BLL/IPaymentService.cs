using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IPaymentService
{
    public Task GetById(int id);
    public Task Delete(int id);
    public Task Create(PaymentRequest request);
    public Task Update();
}

