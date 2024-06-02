using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Common.Services;
public class BaseService
{
    public readonly IUnitOfWork _unitOfWork = null!;
    public readonly UserContext _userContext = null!;
    public readonly IDateTimeProvider _dateTimeProvider = null!;

    public BaseService(IUnitOfWork unitOfWork, IDateTimeProvider dateTimeProvider)
    {
        _unitOfWork = unitOfWork;
        _dateTimeProvider = dateTimeProvider;
    }
    public BaseService(IUnitOfWork unitOfWork, UserContext userContext)
    {
        _unitOfWork = unitOfWork;
        _userContext = userContext;
    }

    public BaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public BaseService(UserContext userContext)
    {
        _userContext = userContext;
    }

    public BaseService()
    {
    }

}