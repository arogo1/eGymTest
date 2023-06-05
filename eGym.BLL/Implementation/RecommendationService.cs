using eGym.BLL.Models;
using eGym.DAL;

namespace eGym.BLL.Implementation;

public class RecommendationService : IRecommendationService
{
    private readonly IUnitOfWork _unitOfWork;

	public RecommendationService(IUnitOfWork unitOfWork)
	{
        _unitOfWork = unitOfWork;
	}

    public async Task<List<Recommendation>> Get(int accountId)
    {
        var accountReservations = await _unitOfWork.Reservations.GetWhere(x => x.AccountId.Equals(accountId));

        var recommendations = new List<Recommendation>();

        if (accountReservations.Any())
        {
        }
        else
        {
            var reservations = await _unitOfWork.Reservations.GetAll();

            reservations.Where(x => x.ReservationType == 0).OrderBy(x => x.EmployeeId);

            //recommendations.Add(new Recommendation() {  })
        }

        return recommendations;
    }
}

