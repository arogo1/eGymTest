using eGym.BLL.Models.Requests;
using Stripe;

namespace eGym.BLL;

public interface IPaymentService
{
    public Task GetById(int id);
    public Task Delete(int id);
    public Task Update();
    Task<Customer> AddCustomer(CustomerRequest customer, CancellationToken ct);
    Task<Charge> AddPayment(PaymentRequest payment, CancellationToken ct);
}

