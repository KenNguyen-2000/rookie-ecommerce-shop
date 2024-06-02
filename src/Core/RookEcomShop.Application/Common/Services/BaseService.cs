using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Common.Services;
public class BaseService
{
    public readonly IUnitOfWork _unitOfWork = null!;
    public readonly UserContext _userContext = null!;

    public BaseService(IUnitOfWork unitOfWork,  UserContext userContext)
    {
        _unitOfWork = unitOfWork;
        _userContext = userContext;
    }

    public BaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public BaseService()
    {
    }

}